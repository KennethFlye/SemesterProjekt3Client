using System.Reflection;
using Input;

namespace SemesterProjekt3Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(System.AppDomain.CurrentDomain.BaseDirectory);
            DirectoryInfo baseDir = fileInfo.Directory.Parent.Parent.Parent;
            string path = baseDir.FullName + "\\Images\\tetris-movie-v0-nxkmsyiumera1.png";

            pictureBoxFrontImage.LoadAsync(path);
            lblTitle.Text = "Vestbjerg Biograf Administratorsystem";

            Font bigFont = new Font("Cascadia Code", 20);
            lblTitle.Font=bigFont;
        }

        Input.KeyValueChecker kv = new Input.KeyValueChecker();
        void Form1_KeyPress(object sender, KeyPressEventArgs e) //Keypress input gets handled here
        {
            if (kv.KeyDown(e.KeyChar, "1", this))
            {
                MessageBox.Show("Shortcut to button 1");
            }
        }        
    }
}