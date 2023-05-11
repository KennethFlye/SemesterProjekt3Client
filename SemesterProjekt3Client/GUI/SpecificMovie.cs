using SemesterProjekt3Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjekt3Client.GUI
{
    public partial class SpecificMovie : Form
    {
        MovieInfo movie;
        public SpecificMovie(MovieInfo movie)
        {
            this.movie = movie;
            InitializeComponent();
            if (movie.CurrentlyShowing)
            {
                label_movieCurrentlyShowing.Text += "Nej";
            }
            else
            {
                label_movieCurrentlyShowing.Text += "Ja";
            }
            label_movieGenre.Text += movie.Genre;
            label_movieImagePath.Text += movie.MovieUrl;
            label_movieLength.Text += movie.Length + " minutter";
            label_moviePGRating.Text += movie.PgRating + " år";
            label_movieReleaseDate.Text += movie.PremiereDate.ToString("dd/MM/yyyy");
            label_movieTitle.Text += movie.Title;


        }


    }
}
