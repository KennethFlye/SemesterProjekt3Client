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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label11 = new Label();
            textBox_updateMovieTitle = new TextBox();
            textBox_updateMovieGenre = new TextBox();
            textBox__updateMoviePGRating = new TextBox();
            textBox_updateMovieLength = new TextBox();
            dateTimePicker_updateMovieReleaseDate = new DateTimePicker();
            textBox_updateMovieImagePage = new TextBox();
            checkBox_updateMovieCurrentlyShowing = new CheckBox();
            btn_back = new Button();
            btn_update = new Button();
            btn_add = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            textBox_filmCopyLanguage = new TextBox();
            textBox_filmCopyPrice = new TextBox();
            checkBox_filmCopyIs3D = new CheckBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(253, 65);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(205, 259);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(253, 43);
            label1.Name = "label1";
            label1.Size = new Size(164, 19);
            label1.TabIndex = 1;
            label1.Text = "Filmkopier for denne film:";
            // 
            // label_movieTitle
            // 
            label_movieTitle.AutoSize = true;
            label_movieTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_movieTitle.Location = new Point(16, 88);
            label_movieTitle.Name = "label_movieTitle";
            label_movieTitle.Size = new Size(64, 19);
            label_movieTitle.TabIndex = 2;
            label_movieTitle.Text = "Filmtitel: ";
            // 
            // label_movieLength
            // 
            label_movieLength.AutoSize = true;
            label_movieLength.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_movieLength.Location = new Point(16, 115);
            label_movieLength.Name = "label_movieLength";
            label_movieLength.Size = new Size(87, 19);
            label_movieLength.TabIndex = 3;
            label_movieLength.Text = "Filmlængde: ";
            // 
            // label_movieGenre
            // 
            label_movieGenre.AutoSize = true;
            label_movieGenre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_movieGenre.Location = new Point(16, 144);
            label_movieGenre.Name = "label_movieGenre";
            label_movieGenre.Size = new Size(53, 19);
            label_movieGenre.TabIndex = 4;
            label_movieGenre.Text = "Genre: ";
            // 
            // label_moviePGRating
            // 
            label_moviePGRating.AutoSize = true;
            label_moviePGRating.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_moviePGRating.Location = new Point(16, 172);
            label_moviePGRating.Name = "label_moviePGRating";
            label_moviePGRating.Size = new Size(100, 19);
            label_moviePGRating.TabIndex = 5;
            label_moviePGRating.Text = "Aldersgrænse: ";
            // 
            // label_movieReleaseDate
            // 
            label_movieReleaseDate.AutoSize = true;
            label_movieReleaseDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_movieReleaseDate.Location = new Point(16, 201);
            label_movieReleaseDate.Name = "label_movieReleaseDate";
            label_movieReleaseDate.Size = new Size(109, 19);
            label_movieReleaseDate.TabIndex = 6;
            label_movieReleaseDate.Text = "Udgivelsesdato: ";
            // 
            // label_movieImagePath
            // 
            label_movieImagePath.AutoSize = true;
            label_movieImagePath.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_movieImagePath.Location = new Point(16, 232);
            label_movieImagePath.Name = "label_movieImagePath";
            label_movieImagePath.Size = new Size(86, 19);
            label_movieImagePath.TabIndex = 7;
            label_movieImagePath.Text = "Image Path: ";
            // 
            // label_movieCurrentlyShowing
            // 
            label_movieCurrentlyShowing.AutoSize = true;
            label_movieCurrentlyShowing.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_movieCurrentlyShowing.Location = new Point(16, 261);
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
            label10.Location = new Point(16, 43);
            label10.Name = "label10";
            label10.Size = new Size(167, 25);
            label10.TabIndex = 10;
            label10.Text = "Film Information:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 411);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 11;
            label2.Text = "Ny filmtitel:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 445);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 12;
            label3.Text = "Ny filmlængde (i minutter):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 474);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 13;
            label4.Text = "Ny genre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 503);
            label5.Name = "label5";
            label5.Size = new Size(128, 15);
            label5.TabIndex = 14;
            label5.Text = "Ny aldersgrænse (i tal):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 536);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 15;
            label6.Text = "Ny udgivelsesdato:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 562);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 16;
            label7.Text = "Ny image path:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(77, 595);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 17;
            label8.Text = "Bliver vist nu:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(34, 348);
            label11.Name = "label11";
            label11.Size = new Size(304, 40);
            label11.TabIndex = 18;
            label11.Text = "Udfyld attributer du ønsker at opdatere\r\nog klik \"Opdater\" for at opdatere denne film";
            // 
            // textBox_updateMovieTitle
            // 
            textBox_updateMovieTitle.Location = new Point(160, 408);
            textBox_updateMovieTitle.Name = "textBox_updateMovieTitle";
            textBox_updateMovieTitle.Size = new Size(100, 23);
            textBox_updateMovieTitle.TabIndex = 19;
            // 
            // textBox_updateMovieGenre
            // 
            textBox_updateMovieGenre.Location = new Point(160, 471);
            textBox_updateMovieGenre.Name = "textBox_updateMovieGenre";
            textBox_updateMovieGenre.Size = new Size(100, 23);
            textBox_updateMovieGenre.TabIndex = 20;
            // 
            // textBox__updateMoviePGRating
            // 
            textBox__updateMoviePGRating.Location = new Point(160, 500);
            textBox__updateMoviePGRating.Name = "textBox__updateMoviePGRating";
            textBox__updateMoviePGRating.Size = new Size(100, 23);
            textBox__updateMoviePGRating.TabIndex = 21;
            // 
            // textBox_updateMovieLength
            // 
            textBox_updateMovieLength.Location = new Point(160, 442);
            textBox_updateMovieLength.Name = "textBox_updateMovieLength";
            textBox_updateMovieLength.Size = new Size(100, 23);
            textBox_updateMovieLength.TabIndex = 22;
            // 
            // dateTimePicker_updateMovieReleaseDate
            // 
            dateTimePicker_updateMovieReleaseDate.Location = new Point(160, 530);
            dateTimePicker_updateMovieReleaseDate.Name = "dateTimePicker_updateMovieReleaseDate";
            dateTimePicker_updateMovieReleaseDate.Size = new Size(200, 23);
            dateTimePicker_updateMovieReleaseDate.TabIndex = 23;
            // 
            // textBox_updateMovieImagePage
            // 
            textBox_updateMovieImagePage.Location = new Point(160, 559);
            textBox_updateMovieImagePage.Name = "textBox_updateMovieImagePage";
            textBox_updateMovieImagePage.Size = new Size(100, 23);
            textBox_updateMovieImagePage.TabIndex = 24;
            // 
            // checkBox_updateMovieCurrentlyShowing
            // 
            checkBox_updateMovieCurrentlyShowing.AutoSize = true;
            checkBox_updateMovieCurrentlyShowing.Location = new Point(160, 596);
            checkBox_updateMovieCurrentlyShowing.Name = "checkBox_updateMovieCurrentlyShowing";
            checkBox_updateMovieCurrentlyShowing.Size = new Size(15, 14);
            checkBox_updateMovieCurrentlyShowing.TabIndex = 25;
            checkBox_updateMovieCurrentlyShowing.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(12, 640);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(83, 34);
            btn_back.TabIndex = 26;
            btn_back.Text = "Tilbage";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(160, 625);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 34);
            btn_update.TabIndex = 27;
            btn_update.Text = "Opdater";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(526, 201);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 34);
            btn_add.TabIndex = 28;
            btn_add.Text = "Tilføj";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(509, 28);
            label12.Name = "label12";
            label12.Size = new Size(236, 40);
            label12.TabIndex = 29;
            label12.Text = "Tilføj ny filmkopi ved at udfylde\r\nde tomme felter og klik på \"Tilføj\"";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(509, 92);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 30;
            label13.Text = "Sprog:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(526, 128);
            label14.Name = "label14";
            label14.Size = new Size(24, 15);
            label14.TabIndex = 31;
            label14.Text = "3D:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(521, 161);
            label15.Name = "label15";
            label15.Size = new Size(29, 15);
            label15.TabIndex = 32;
            label15.Text = "Pris:";
            // 
            // textBox_filmCopyLanguage
            // 
            textBox_filmCopyLanguage.Location = new Point(569, 88);
            textBox_filmCopyLanguage.Name = "textBox_filmCopyLanguage";
            textBox_filmCopyLanguage.Size = new Size(100, 23);
            textBox_filmCopyLanguage.TabIndex = 33;
            // 
            // textBox_filmCopyPrice
            // 
            textBox_filmCopyPrice.Location = new Point(569, 161);
            textBox_filmCopyPrice.Name = "textBox_filmCopyPrice";
            textBox_filmCopyPrice.Size = new Size(100, 23);
            textBox_filmCopyPrice.TabIndex = 34;
            // 
            // checkBox_filmCopyIs3D
            // 
            checkBox_filmCopyIs3D.AutoSize = true;
            checkBox_filmCopyIs3D.Location = new Point(569, 128);
            checkBox_filmCopyIs3D.Name = "checkBox_filmCopyIs3D";
            checkBox_filmCopyIs3D.Size = new Size(15, 14);
            checkBox_filmCopyIs3D.TabIndex = 35;
            checkBox_filmCopyIs3D.UseVisualStyleBackColor = true;
            // 
            // SpecificMovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 686);
            Controls.Add(checkBox_filmCopyIs3D);
            Controls.Add(textBox_filmCopyPrice);
            Controls.Add(textBox_filmCopyLanguage);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(btn_add);
            Controls.Add(btn_update);
            Controls.Add(btn_back);
            Controls.Add(checkBox_updateMovieCurrentlyShowing);
            Controls.Add(textBox_updateMovieImagePage);
            Controls.Add(dateTimePicker_updateMovieReleaseDate);
            Controls.Add(textBox_updateMovieLength);
            Controls.Add(textBox__updateMoviePGRating);
            Controls.Add(textBox_updateMovieGenre);
            Controls.Add(textBox_updateMovieTitle);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label11;
        private TextBox textBox_updateMovieTitle;
        private TextBox textBox_updateMovieGenre;
        private TextBox textBox__updateMoviePGRating;
        private TextBox textBox_updateMovieLength;
        private DateTimePicker dateTimePicker_updateMovieReleaseDate;
        private TextBox textBox_updateMovieImagePage;
        private CheckBox checkBox_updateMovieCurrentlyShowing;
        private Button btn_back;
        private Button btn_update;
        private Button btn_add;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox textBox_filmCopyLanguage;
        private TextBox textBox_filmCopyPrice;
        private CheckBox checkBox_filmCopyIs3D;
    }
}