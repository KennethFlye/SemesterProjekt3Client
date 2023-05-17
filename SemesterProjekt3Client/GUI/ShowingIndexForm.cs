using SemesterProjekt3Client.Controllers;
using SemesterProjekt3Client.GUI;
using SemesterProjekt3Client.Model;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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

            //var rTemplist = _showRoomCtrl.GetShowRooms();
            //_roomList = rTemplist.GetAwaiter().GetResult();
            //foreach (var i in _roomList)
            //{
            //    _roomList.Items.Add(i);
            //}
        }




        private async Task FillLists()
        {
            await UpdateMovieComboBox();
            //UpdateRoomComboBox();
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
                foreach (Showing? i in _showingList)
                {

                    showingsList.Items.Add(i);
                }
            }
        }

        private void showingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (showingsList.SelectedItem != null)
            {
                ShowingEditForm form = new ShowingEditForm((Showing)showingsList.SelectedItem);
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



                DateTime date = datePicker.Value;
                DateTime time = timePicker.Value;
                DateTime starttime = new DateTime(date.Year, date.Month, date.Month, time.Hour, time.Minute, time.Second);

                int rId = ShowRoomComboBox.SelectedItem.ToString().First();
                ShowRoom room = await _roomCtrl.GetShowRoomById(rId);

                int mId = movieComboBox.SelectedItem.ToString().First();
                MovieCopy movie =  await _movieCtrl.GetMovieCopyAsync(mId);
               
                bool kid = false;
                if (kidCheckBox.Checked)
                {
                    kid = true;
                }



                Showing newShow = new Showing(starttime, kid, room, movie);
                bool savedOk = await _showingCtrl.CreateShowing(newShow);
                if (savedOk)
                {

                    await UpdateShowingList();
                    titleLabel.Text = "Shauning was succesfully uploaded to database" + room.RoomNumber;

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
                    movieComboBox.Items.Add(i.CopyId);
                }
            }

    }

        public async void UpdateRoomComboBox()
        {
            _roomList = await _roomCtrl.GetShowRooms();
            ShowRoomComboBox.Items.Clear();
            if (_roomList.Count() < 1)
            {
                foreach (var i in _roomList)
                {
                    ShowRoomComboBox.Items.Add(i.RoomNumber);
                }
            }
        }
    }
}