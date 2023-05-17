using SemesterProjekt3Client.Controllers;
using SemesterProjekt3Client.GUI;
using SemesterProjekt3Client.Model;

namespace SemesterProjekt3Client
{
    public partial class ShowingIndexForm : Form
    {
        private readonly ShowingController _showingCtrl;
        private readonly MovieController _movieCtrl;
        private readonly ShowRoomController _roomCtrl;
        private IEnumerable<Showing>? _showingList;
        private IEnumerable<MovieCopy> _movieList;
        private IEnumerable<ShowRoom> _roomList;


        public ShowingIndexForm()
        {

            InitializeComponent();

            _showingCtrl = new ShowingController();
            _movieCtrl = new MovieController();
            _roomCtrl = new ShowRoomController();

            FillLists();


        }

        private async Task FillLists()
        {
            await UpdateMovieComboBox();
            await UpdateRoomComboBox();
            await UpdateShowingList();
        }


        private async void getButton_Click(object sender, EventArgs e)
        {
            FillLists();
        }

        public async Task UpdateShowingList()
        {
            _showingList = await _showingCtrl.GetShowingsAsync();
            if (_showingList.Count() > 0)
            {

                showingsList.Items.Clear();
                foreach (Showing i in _showingList)
                {

                    showingsList.Items.Add(i);
                }
            }
        }

        private void showingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (showingsList.SelectedItem != null)
            {
                SpecificShowing form = new SpecificShowing((Showing)showingsList.SelectedItem);

                this.Dispose();
                form.ShowDialog();
                
            }
        }


        private async void createButton_Click(object sender, EventArgs e)

        {

            titleLabel.Text = "start";
            string displayMsg = "Udfyld venligst følgende felter korrekt:";
            string originalDisplayMsg = displayMsg;

            if (string.IsNullOrWhiteSpace(movieComboBox.Text))
            {
                displayMsg += "\nFilm";
            }

            if (string.IsNullOrWhiteSpace(ShowRoomComboBox.Text))
            {
                displayMsg += "\nSal";
            }

            if (!displayMsg.Equals(originalDisplayMsg))
            {
                titleLabel.Text = displayMsg;
            }
            else
            {

                Showing newShow = new();

                DateTime date = datePicker.Value;
                DateTime time = timePicker.Value;
                DateTime starttime = new DateTime(date.Year, date.Month, date.Month, time.Hour, time.Minute, time.Second);

                newShow.startTime = starttime;
                newShow.ShowRoom = (ShowRoom)ShowRoomComboBox.SelectedItem;
                newShow.MovieCopy = (MovieCopy)movieComboBox.SelectedItem;
                newShow.IsKidFriendly = kidCheckBox.Checked;


                bool savedOk = await _showingCtrl.CreateShowing(newShow);
                if (savedOk)
                {

                    await UpdateShowingList();
                    titleLabel.Text = "Shauning was succesfully uploaded to database";

                }
                else
                {
                    titleLabel.Text = "Something went wrong, thw show was not added to database";
                }
            }
        }
        public async Task UpdateMovieComboBox()
        {
            _movieList = await _movieCtrl.GetAllMovieCopiesAsync();
            if (_movieList.Count() > 0)
            {
                movieComboBox.Items.Clear();
                foreach (var i in _movieList)
                {
                    movieComboBox.Items.Add(i);
                }
            }

        }

        public async Task UpdateRoomComboBox()
        {
            _roomList = await _roomCtrl.GetShowRooms();

            if (_roomList.Count() > 0)
            {
                ShowRoomComboBox.Items.Clear();
                foreach (var i in _roomList)
                {
                    ShowRoomComboBox.Items.Add(i);
                }
            }
        }
    }
}