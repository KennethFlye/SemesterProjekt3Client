using SemesterProjekt3Client.Controllers;
using SemesterProjekt3Client.Model;
using System.Text.RegularExpressions;

namespace SemesterProjekt3Client.GUI
{
    public partial class SpecificMovie : Form
    {
        MovieInfo movie;
        MovieController mController;
        IEnumerable<MovieCopy> dbMovieCopies;

        public SpecificMovie(MovieInfo movie)
        {
            this.movie = movie;
            InitializeComponent();
            if (movie.CurrentlyShowing)
            {
                label_movieCurrentlyShowing.Text += "Ja";
            }
            else
            {
                label_movieCurrentlyShowing.Text += "Nej";
            }
            label_movieGenre.Text += movie.Genre;
            label_movieImagePath.Text += movie.MovieUrl;
            label_movieLength.Text += movie.Length + " minutter";
            label_moviePGRating.Text += movie.PgRating + " år";
            label_movieReleaseDate.Text += movie.PremiereDate.ToString("dd/MM/yyyy");
            label_movieTitle.Text += movie.Title;
            mController = new MovieController();
            FillMovieCopyListAsync();


        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            string displayMsg = "Udfyld venligst følgende felter korrekt:";
            string originalDisplayMsg = displayMsg;

            if (string.IsNullOrWhiteSpace(textBox_filmCopyLanguage.Text))
            {
                displayMsg += "\nSprog";
            }

            if (string.IsNullOrWhiteSpace(textBox_filmCopyPrice.Text) || !(Regex.IsMatch(textBox_filmCopyPrice.Text, "^-?\\d+(\\.\\d+)?$")))
            {
                displayMsg += "\nPris";
            }

            if (!displayMsg.Equals(originalDisplayMsg))
            {
                MessageBox.Show(displayMsg);
            }
            else
            {
                string language = textBox_filmCopyLanguage.Text;
                bool is3D = checkBox_filmCopyIs3D.Checked;
                double price = Convert.ToDouble(textBox_filmCopyPrice.Text);

                MovieCopy movieCopy = new MovieCopy(0, language, is3D, price, movie);
                bool savedOk = await mController.AddMovieCopyAsync(movieCopy);
                if (savedOk)
                {
                    FillMovieCopyListAsync();
                    MessageBox.Show("Movie copy was succesfully uploaded to database");
                }
                else
                {
                    MessageBox.Show("Something went wrong, movie copy was not added to database");
                }
            }
        }

        public async void FillMovieCopyListAsync()
        {

            dbMovieCopies = await mController.GetAllMovieCopiesAsync();
            listBox1.Items.Clear();

            foreach (MovieCopy movieCopy in dbMovieCopies)
            {
                if (movieCopy.MovieType.InfoId == movie.InfoId)
                {
                    listBox1.Items.Add(movieCopy);
                }

            }
        }


        private async void btn_update_Click(object sender, EventArgs e)
        {
            bool updated = false;
            string updatedTitle = movie.Title;
            int updatedLength = movie.Length;
            string updatedGenre = movie.Genre;
            string updatedPGRating = movie.PgRating;
            DateTime updatedReleaseDate = movie.PremiereDate;
            string updatedImagePath = movie.MovieUrl;
            bool updatedCurrentlyShowing = movie.CurrentlyShowing;


            if (!string.IsNullOrWhiteSpace(textBox_updateMovieTitle.Text))
            {
                updatedTitle = textBox_updateMovieTitle.Text;
                updated = true;
            }
            if (!string.IsNullOrWhiteSpace(textBox_updateMovieLength.Text) && (Regex.IsMatch(textBox_updateMovieLength.Text, @"^\d+$")))
            {
                updatedLength = Int32.Parse(textBox_updateMovieLength.Text);
                updated = true;
            }
            if (!string.IsNullOrWhiteSpace(textBox_updateMovieGenre.Text))
            {
                updatedGenre = textBox_updateMovieGenre.Text;
                updated = true;
            }
            if (!string.IsNullOrWhiteSpace(textBox__updateMoviePGRating.Text))
            {
                updatedPGRating = textBox__updateMoviePGRating.Text;
                updated = true;
            }
            if (!dateTimePicker_updateMovieReleaseDate.Value.Equals(movie.PremiereDate))
            {
                updatedReleaseDate = dateTimePicker_updateMovieReleaseDate.Value;
                updated = true;
            }
            if (!string.IsNullOrWhiteSpace(textBox_updateMovieImagePage.Text))
            {
                updatedImagePath = textBox_updateMovieImagePage.Text;
                updated = true;
            }
            if (checkBox_updateMovieCurrentlyShowing.Checked != movie.CurrentlyShowing)
            {
                updatedCurrentlyShowing = checkBox_updateMovieCurrentlyShowing.Checked;
                updated = true;
            }

            if (!updated)
            {
                MessageBox.Show("Atleast one attribute must be updated!");
            }
            else
            {
                MovieInfo movieInfo = new MovieInfo(movie.InfoId, updatedTitle, updatedLength, updatedGenre, updatedPGRating, updatedReleaseDate, updatedCurrentlyShowing, updatedImagePath);
                bool updatedInDB = await mController.UpdateMovieInfoAsync(movieInfo);

                if (updatedInDB)
                {
                    MessageBox.Show("Movie was succesfully updated in database. Please restart program to see changes!");
                }
                else
                {
                    MessageBox.Show("Something went wrong, movie was not updated in database");
                }


            }


        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                MovieEditForm specificMovieCopyWindow = new MovieEditForm((MovieCopy)listBox1.SelectedItem);
                specificMovieCopyWindow.ShowDialog();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
