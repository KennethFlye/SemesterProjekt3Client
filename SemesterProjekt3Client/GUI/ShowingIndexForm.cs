using SemesterProjekt3Client.Controllers;
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
            _showingList = await _showingCtrl.GetShowings();
            if (_showingList.Count() > 0)
            {

                showingsList.Items.Clear();
                foreach (Showing? i in _showingList)
                {

                    showingsList.Items.Add(i.ToString());
                }
            }



        //private void createButton_Click(object sender, EventArgs e)
        //{
        //    Showing show = new();
        //    show.MovieCopy = movieComboBox.Text;
        //    show.ShowRoom = ShowRoomComboBox.Text;
        //    show.startTime = dateTimePicker1.Text;
        //    if(kidCheckBox.Checked)
        //    {
        //        show.IsKidFriendly = true;
        //    }
        //    _showingCtrl.CreateShowing(show);


            //}
        }
        public async Task UpdateMovieComboBox()
        {
            _movieList = await _movieCtrl.GetMoviesCopy();
            if (_movieList.Count() > 0)
            {
                movieComboBox.Items.Clear();
                foreach (var i in _movieList)
                {
                    movieComboBox.Items.Add(i.ToString());
                }
            }

    }

        //public async void UpdateRoomComboBox()
        //{
        //    _roomList = await _roomCtrl.GetMoviesCopy();
        //    showRoomComboBox.Items.Clear();
        //    if (_roomList.Count() < 1)
        //    {
        //        foreach (var i in _roomList)
        //        {
        //            showRoomComboBox.Items.Add(i.RoomNumber);
        //        }
        //    }
        //}
    }
}