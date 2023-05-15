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

            getLists();

            UpdateMovieComboBox(_movieList);
            //UpdateRoomComboBox();
            UpdateShowingList(_showingList);



            //var rTemplist = _showRoomCtrl.GetShowRooms();
            //_roomList = rTemplist.GetAwaiter().GetResult();
            //foreach (var i in _roomList)
            //{
            //    _roomList.Items.Add(i);
            //}
        }







        private void getButton_Click(object sender, EventArgs e)
        {
            UpdateShowingList(_showingList);
            UpdateMovieComboBox(_movieList);
            //UpdateRoomComboBox();
         

        }
        public async void UpdateShowingList(IEnumerable<Showing> list)
        {

           // _showingList = await _showingCtrl.GetShowingsAsync();



            if (_showingList.Count() > 0 && _movieList != null)
            {

                showingsList.Items.Clear();
                foreach (Showing? i in _showingList)
                {

                    showingsList.Items.Add(i.ToString());
                }
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
    
    public  void UpdateMovieComboBox(IEnumerable<MovieCopy> list)
    {

        //_movieList = await list.GetMoviesCopy();

            if (list.Count() > 0 && list != null)
            {

                movieComboBox.Items.Clear();

                foreach (var i in list)
                {
                    movieComboBox.Items.Add(i.ToString());
                }
            }

    }

    public  async void getLists()
        {
            _showingList  = await _showingCtrl.GetShowingsAsync();
            _movieList = await _movieCtrl.GetMoviesCopy();
            
        }



    //public async void UpdateRoomComboBox()
    //{
    //    _roomList = await _roomCtrl.GetShowRooms();
    //    ShowRoomComboBox.Items.Clear();
        

    //    foreach (var i in _roomList)
    //    {
    //        ShowRoomComboBox.Items.Add(i.RoomNumber);
    //    }

    //}


}
}