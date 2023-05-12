using Microsoft.VisualBasic.Devices;
using SemesterProjekt3Client.Controllers;
using SemesterProjekt3Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private async void btn_update_Click(object sender, EventArgs e)
        {
            bool updated = false;
            string updatedLanguage = movieCopy.Language;
            bool updatedIs3D = movieCopy.Is3D;
            double updatedPrice = movieCopy.Price;

            if (!string.IsNullOrWhiteSpace(textBox_updateMovieCopyLanguage.Text))
            {
                updatedLanguage = textBox_updateMovieCopyLanguage.Text;
                updated = true;
            }
            if (checkBox_updateIs3D.Checked != movieCopy.Is3D)
            {
                updatedIs3D = checkBox_updateIs3D.Checked;
                updated = true;
            }
            if (!string.IsNullOrWhiteSpace(textBox_updateMovieCopyPrice.Text) && (Regex.IsMatch(textBox_updateMovieCopyPrice.Text, "^-?\\d+(\\.\\d+)?$")))
            {
                updatedPrice = Double.Parse(textBox_updateMovieCopyPrice.Text);
                updated = true;
            }

            if (!updated)
            {
                MessageBox.Show("Atleast one attribute must be updated!");
            }
            else
            {
                MovieCopy newMovieCopy = new MovieCopy(movieCopy.CopyId, updatedLanguage, updatedIs3D, updatedPrice, movieCopy.MovieType);
                bool updatedInDB = await mController.UpdateMovieCopyAsync(newMovieCopy);

                if (updatedInDB)
                {
                    MessageBox.Show("Movie copy was succesfully updated in database. Please restart program to see changes!");
                }
                else
                {
                    MessageBox.Show("Something went wrong, movie copy was not updated in database");
                }


            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
