namespace SemesterProjekt3Client.GUI
{
    partial class SpecificMovie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            label1 = new Label();
            label_movieTitle = new Label();
            label_movieLength = new Label();
            label_movieGenre = new Label();
            label_moviePGRating = new Label();
            label_movieReleaseDate = new Label();
            label_movieImagePath = new Label();
            label_movieCurrentlyShowing = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(283, 71);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(205, 259);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 43);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 1;
            label1.Text = "Filmkopier for denne film:";
            // 
            // label_movieTitle
            // 
            label_movieTitle.AutoSize = true;
            label_movieTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_movieTitle.Location = new Point(23, 89);
            label_movieTitle.Name = "label_movieTitle";
            label_movieTitle.Size = new Size(64, 19);
            label_movieTitle.TabIndex = 2;
            label_movieTitle.Text = "Filmtitel: ";
            // 
            // label_movieLength
            // 
            label_movieLength.AutoSize = true;
            label_movieLength.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_movieLength.Location = new Point(23, 116);
            label_movieLength.Name = "label_movieLength";
            label_movieLength.Size = new Size(87, 19);
            label_movieLength.TabIndex = 3;
            label_movieLength.Text = "Filmlængde: ";
            // 
            // label_movieGenre
            // 
            label_movieGenre.AutoSize = true;
            label_movieGenre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_movieGenre.Location = new Point(23, 142);
            label_movieGenre.Name = "label_movieGenre";
            label_movieGenre.Size = new Size(53, 19);
            label_movieGenre.TabIndex = 4;
            label_movieGenre.Text = "Genre: ";
            // 
            // label_moviePGRating
            // 
            label_moviePGRating.AutoSize = true;
            label_moviePGRating.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_moviePGRating.Location = new Point(23, 169);
            label_moviePGRating.Name = "label_moviePGRating";
            label_moviePGRating.Size = new Size(100, 19);
            label_moviePGRating.TabIndex = 5;
            label_moviePGRating.Text = "Aldersgrænse: ";
            // 
            // label_movieReleaseDate
            // 
            label_movieReleaseDate.AutoSize = true;
            label_movieReleaseDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_movieReleaseDate.Location = new Point(23, 194);
            label_movieReleaseDate.Name = "label_movieReleaseDate";
            label_movieReleaseDate.Size = new Size(109, 19);
            label_movieReleaseDate.TabIndex = 6;
            label_movieReleaseDate.Text = "Udgivelsesdato: ";
            // 
            // label_movieImagePath
            // 
            label_movieImagePath.AutoSize = true;
            label_movieImagePath.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_movieImagePath.Location = new Point(24, 222);
            label_movieImagePath.Name = "label_movieImagePath";
            label_movieImagePath.Size = new Size(86, 19);
            label_movieImagePath.TabIndex = 7;
            label_movieImagePath.Text = "Image Path: ";
            // 
            // label_movieCurrentlyShowing
            // 
            label_movieCurrentlyShowing.AutoSize = true;
            label_movieCurrentlyShowing.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_movieCurrentlyShowing.Location = new Point(23, 248);
            label_movieCurrentlyShowing.Name = "label_movieCurrentlyShowing";
            label_movieCurrentlyShowing.Size = new Size(94, 19);
            label_movieCurrentlyShowing.TabIndex = 8;
            label_movieCurrentlyShowing.Text = "Bliver vist nu: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 60);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(23, 43);
            label10.Name = "label10";
            label10.Size = new Size(167, 25);
            label10.TabIndex = 10;
            label10.Text = "Film Information:";
            // 
            // SpecificMovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 486);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label_movieCurrentlyShowing);
            Controls.Add(label_movieImagePath);
            Controls.Add(label_movieReleaseDate);
            Controls.Add(label_moviePGRating);
            Controls.Add(label_movieGenre);
            Controls.Add(label_movieLength);
            Controls.Add(label_movieTitle);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "SpecificMovie";
            Text = "SpecificMovie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label_movieTitle;
        private Label label_movieLength;
        private Label label_movieGenre;
        private Label label_moviePGRating;
        private Label label_movieReleaseDate;
        private Label label_movieImagePath;
        private Label label_movieCurrentlyShowing;
        private Label label9;
        private Label label10;
    }
}