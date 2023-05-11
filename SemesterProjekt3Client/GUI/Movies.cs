using Microsoft.VisualBasic.Devices;
using SemesterProjekt3Client.Controllers;
using SemesterProjekt3Client.Model;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SemesterProjekt3Client
{
    public partial class Movies : Form
    {
        MovieController mController;
        IEnumerable<MovieInfo> dbMovies;
        public Movies()
        {
            InitializeComponent();
            mController = new MovieController();
            FillMovieListAsync();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            
            string displayMsg = "Udfyld venligst følgende felter korrekt:";
            string originalDisplayMsg = displayMsg;

            if (string.IsNullOrWhiteSpace(textBox_Title.Text))
            {
                displayMsg += "\nFilmtitel";
            }

            if (string.IsNullOrWhiteSpace(textBox_Length.Text) || !(Regex.IsMatch(textBox_Length.Text, @"^\d+$")))
            {
                displayMsg += "\nFilmlængde";
            }

            if (string.IsNullOrWhiteSpace(textBox_Genre.Text))
            {
                displayMsg += "\nGenre";
            }

            if (string.IsNullOrWhiteSpace(textBox_PGRating.Text))
            {
                displayMsg += "\nAldersgrænse";
            }

            if (string.IsNullOrWhiteSpace(textBox_ImagePath.Text))
            {
                displayMsg += "\nImage Path";
            }

            if (!displayMsg.Equals(originalDisplayMsg))
            {
                MessageBox.Show(displayMsg);
            }
            else
            {
                string title = textBox_Title.Text;
                int length = Int32.Parse(textBox_Length.Text);
                string genre = textBox_Genre.Text;
                string pgRating = textBox_PGRating.Text;
                DateTime releaseDate = dateTimePicker1.Value;
                string imagePath = textBox_ImagePath.Text;

                MovieInfo newMovie = new MovieInfo(0, title, length, genre, pgRating, releaseDate, true, imagePath);
                bool savedOk = await mController.AddMovieInfoAsync(newMovie);
                if (savedOk)
                {
                    FillMovieListAsync();
                    MessageBox.Show("Movie was succesfully uploaded to database");
                }
                else
                {
                    MessageBox.Show("Something went wrong, movie was not added to database");
                }

            }

        }

        public async void FillMovieListAsync()
        {
            listBox1.Items.Clear();
            dbMovies = await mController.GetAllMovieInfosAsync();

            foreach (MovieInfo movie in dbMovies)
            {
                listBox1.Items.Add(movie);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SpecificMovie specificMovieWindow = new SpecificMovie(listBox1.SelectedItem);
            specificMovieWindow.ShowDialog();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}