using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SemesterProjekt3Client.Controllers;
using SemesterProjekt3Client.Model;

namespace SemesterProjekt3Client.GUI
{
    public partial class SpecificShowing : Form
    {
        Showing showing;
        List<ShowRoom> showrooms;
        List<MovieCopy> moviecopies;
        public SpecificShowing(Showing showing)
        {
            InitializeComponent();
            this.showing = showing;
            AssignInformationToControlsAsync(showing);
        }

        public SpecificShowing()
        {
            InitializeComponent();

            /*Showing s = new Showing();
            s.ShowingId = 3;
            s.startTime = DateTime.Now;
            MovieCopy mc = new MovieCopy();
            mc.Price = 341;

            MovieInfo mi = new MovieInfo(4,"gaming the movie", 34, "Action", "7", DateTime.Now,true,"Gaming.jpg");
            mc.MovieType = mi;
            mc.Language = "Danish";
            mc.CopyId = 4;
            
            s.MovieCopy = mc;
            s.IsKidFriendly = true;
            s.ShowingId = 3;

            ShowRoom sr = new ShowRoom();
            sr.Seats = new List<Seat>() {new Seat(),new Seat() };
            sr.Capacity = 103;
            sr.RoomNumber = 4;
            s.ShowRoom = sr; //sr is a stub*/



            AssignInformationToControlsAsync(showing);
        }
        private async Task AssignInformationToControlsAsync(Showing s)
        {
            ShowRoomController src = new();
            MovieController mc = new();
            showrooms = new();
            moviecopies = new();
            showrooms = (List<ShowRoom>)await src.GetShowRooms();
            moviecopies = (List<MovieCopy>)await mc.GetAllMovieCopiesAsync();

            if (showing == null) //TODO STUB TODO STUB - WARNING - REMOVE LATER WHEN SHOWING ID IS ASSIGNED IN CONSTRUCTOR
            {
                ShowingController showingController = new ShowingController();
                this.showing = await showingController.GetShowingById(showing.ShowingId);
            }

            textBoxShowingId.Text = showing.ShowingId.ToString();
            dateTimePicker1.Value = showing.startTime;
            checkBoxIsKidFriendly.Checked = showing.IsKidFriendly;

            comboBoxShowRoom.Items.Clear();
            comboBoxMovieCopy.Items.Clear();

            for (int i = 0; i < showrooms.Count; i++)
            {
                var item = showrooms[i];
                comboBoxShowRoom.Items.Add("Sal" + item.RoomNumber ); //Fill combobox
                if (item.RoomNumber == showing.ShowRoom.RoomNumber)
                    comboBoxShowRoom.SelectedIndex = i;
            }

            for (int i = 0; i < moviecopies.Count; i++)
            {
                var item = moviecopies[i];
                comboBoxMovieCopy.Items.Add(item.MovieType.Title + " " + item.ToString());
                if (item.CopyId == showing.MovieCopy.CopyId)
                    comboBoxMovieCopy.SelectedIndex = i;
            }

        }

        private async Task AssignNewValuesToShowing(Showing s)
        {
            //Id
            try { showing.ShowingId = int.Parse(textBoxShowingId.Text); }
            catch (Exception) { MessageBox.Show("Id must be an integer value!"); }
            //StartTime
            showing.startTime = dateTimePicker1.Value;
            //IsKidFriendly
            showing.IsKidFriendly = checkBoxIsKidFriendly.Checked;

            //Showroom
            showing.ShowRoom = showrooms[comboBoxShowRoom.SelectedIndex];
            //MovieCopy
            showing.MovieCopy = moviecopies[comboBoxMovieCopy.SelectedIndex];
            
            await AssignInformationToControlsAsync(showing);
        }


        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            await AssignNewValuesToShowing(showing);

            //post the data change
            ShowingController sc = new ShowingController();
            
            if (await sc.UpdateShowing(showing.ShowingId, showing))
            {
                MessageBox.Show("The showing has been updated.");
                this.Dispose();
                
            }
        }

    }
}
