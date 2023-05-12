using SemesterProjekt3Client.Controllers;
using SemesterProjekt3Client.Model;

namespace SemesterProjekt3Client
{
    public partial class ShowingIndexForm : Form
    {
        private readonly ShowingController _showingCtrl;
        private readonly MovieController _movieCtrl;
        private IEnumerable<Showing>? _showingList;
        private IEnumerable<MovieCopy> _movieList;
        private IEnumerable<ShowRoom> _roomList;


        public ShowingIndexForm()
        {
            InitializeComponent();
            
            _showingCtrl = new ShowingController();
            _movieCtrl = new MovieController();


            AddMoviesCopy();
            //var rTemplist = _showRoomCtrl.GetShowRooms();
            //_roomList = rTemplist.GetAwaiter().GetResult();
            //foreach (var i in _roomList)
            //{
            //    _roomList.Items.Add(i);
            //}
        }

      
        public async void AddMoviesCopy()
        {
            _movieList = await _movieCtrl.GetMoviesCopy();
            foreach (var i in _movieList)
            {
                movieComboBox.Items.Add(i);
            }
        }


       

        private async void getButton_Click(object sender, EventArgs e)
        {
            _showingList = await _showingCtrl.GetShowings();

            // MessageBox.Show("" + allProducts.Count());
            showingListBox.Items.Clear();
            if (_showingList != null)
            {
                foreach (Showing? i in _showingList)
                {
                    
                    showingListBox.Items.Add(i.ShowingId.ToString());

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
    }
}