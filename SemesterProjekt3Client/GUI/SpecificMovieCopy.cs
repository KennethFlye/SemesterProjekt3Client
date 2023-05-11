using SemesterProjekt3Client.Controllers;
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
    public partial class SpecificMovieCopy : Form
    {
        MovieCopy movieCopy;
        MovieController mController;

        public SpecificMovieCopy(MovieCopy movieCopy)
        {
            this.movieCopy = movieCopy;
            mController = new MovieController();
            InitializeComponent();
            if (movieCopy.Is3D)
            {
                label_movieCopy3D.Text += "Ja";
            }
            else
            {
                label_movieCopy3D.Text += "Nej";
            }
            label_movieCopyLanguage.Text += movieCopy.Language;
            label_movieCopyPrice.Text += movieCopy.Price + " kr";
        }
    }
}
