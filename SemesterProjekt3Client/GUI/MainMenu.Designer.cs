namespace SemesterProjekt3Client
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMovies = new System.Windows.Forms.Button();
            this.pictureBoxFrontImage = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnShowings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrontImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMovies
            // 
            this.btnMovies.Location = new System.Drawing.Point(42, 142);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(134, 40);
            this.btnMovies.TabIndex = 0;
            this.btnMovies.Text = "Film";
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // pictureBoxFrontImage
            // 
            this.pictureBoxFrontImage.Location = new System.Drawing.Point(723, 79);
            this.pictureBoxFrontImage.Name = "pictureBoxFrontImage";
            this.pictureBoxFrontImage.Size = new System.Drawing.Size(278, 371);
            this.pictureBoxFrontImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFrontImage.TabIndex = 1;
            this.pictureBoxFrontImage.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(42, 14);
            this.lblTitle.MaximumSize = new System.Drawing.Size(670, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(665, 40);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Det styrer du selv, jeg kan ikke hjælpe dig, der må jeg ikke. Jeg er ligesom en l" +
    "ærer til eksamen. Jeg kan hjælpe dig til råds, men jeg må ikke hjælpe dig.";
            // 
            // btnShowings
            // 
            this.btnShowings.Location = new System.Drawing.Point(42, 188);
            this.btnShowings.Name = "btnShowings";
            this.btnShowings.Size = new System.Drawing.Size(134, 40);
            this.btnShowings.TabIndex = 3;
            this.btnShowings.Text = "Forestillinger";
            this.btnShowings.UseVisualStyleBackColor = true;
            this.btnShowings.Click += new System.EventHandler(this.btnShowings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 487);
            this.Controls.Add(this.btnShowings);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBoxFrontImage);
            this.Controls.Add(this.btnMovies);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrontImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMovies;
        private PictureBox pictureBoxFrontImage;
        private Label lblTitle;
        private Button btnShowings;
    }
}