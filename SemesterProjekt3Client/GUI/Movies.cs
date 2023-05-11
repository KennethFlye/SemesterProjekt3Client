using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SemesterProjekt3Client
{
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
            FillMovieList();
        }

        private void btn_add_Click(object sender, EventArgs e)
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
                string length = textBox_Length.Text;
                string genre = textBox_Genre.Text;
                string pgRating = textBox_PGRating.Text;
                DateTime releaseDate = dateTimePicker1.Value;
                string imagePath = textBox_ImagePath.Text;
                //Metode her der tilføjer filmen til databasen


            }

        }

        public void FillMovieList()
        {
            listBox1.Items.Add("Heyoo");
            listBox1.Items.Add("LMAOO");
            listBox1.Items.Add("GGGG");
            //Metode her der fylder listen med film i databasen
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show((string)listBox1.SelectedItem);

            //Metode her der kalder det valgte elements vindue
        }
    }
}