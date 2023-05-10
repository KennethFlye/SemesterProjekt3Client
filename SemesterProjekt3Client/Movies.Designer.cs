namespace SemesterProjekt3Client
{
    partial class Movies
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
            listBox1 = new ListBox();
            btn_back = new Button();
            btn_add = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox_Title = new TextBox();
            textBox_Length = new TextBox();
            textBox_Genre = new TextBox();
            textBox_PGRating = new TextBox();
            textBox_ImagePath = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(68, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(242, 304);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(12, 406);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(86, 32);
            btn_back.TabIndex = 1;
            btn_back.Text = "Tilbage";
            btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(586, 384);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(86, 32);
            btn_add.TabIndex = 2;
            btn_add.Text = "Tilføj";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 40);
            label1.Name = "label1";
            label1.Size = new Size(218, 21);
            label1.TabIndex = 4;
            label1.Text = "Vælg en film fra databasen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(373, 41);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 5;
            // 
            // textBox_Title
            // 
            textBox_Title.Location = new Point(586, 86);
            textBox_Title.Name = "textBox_Title";
            textBox_Title.Size = new Size(100, 23);
            textBox_Title.TabIndex = 6;
            // 
            // textBox_Length
            // 
            textBox_Length.Location = new Point(586, 135);
            textBox_Length.Name = "textBox_Length";
            textBox_Length.Size = new Size(100, 23);
            textBox_Length.TabIndex = 7;
            // 
            // textBox_Genre
            // 
            textBox_Genre.Location = new Point(586, 186);
            textBox_Genre.Name = "textBox_Genre";
            textBox_Genre.Size = new Size(100, 23);
            textBox_Genre.TabIndex = 8;
            // 
            // textBox_PGRating
            // 
            textBox_PGRating.Location = new Point(586, 239);
            textBox_PGRating.Name = "textBox_PGRating";
            textBox_PGRating.Size = new Size(100, 23);
            textBox_PGRating.TabIndex = 9;
            // 
            // textBox_ImagePath
            // 
            textBox_ImagePath.Location = new Point(586, 335);
            textBox_ImagePath.Name = "textBox_ImagePath";
            textBox_ImagePath.Size = new Size(202, 23);
            textBox_ImagePath.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(586, 287);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(194, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(520, 90);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 12;
            label3.Text = "Filmtitel:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(421, 139);
            label4.Name = "label4";
            label4.Size = new Size(155, 19);
            label4.TabIndex = 13;
            label4.Text = "Filmlængde (i minutter):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(531, 190);
            label5.Name = "label5";
            label5.Size = new Size(49, 19);
            label5.TabIndex = 14;
            label5.Text = "Genre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(484, 243);
            label6.Name = "label6";
            label6.Size = new Size(96, 19);
            label6.TabIndex = 15;
            label6.Text = "Aldersgrænse:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(475, 287);
            label7.Name = "label7";
            label7.Size = new Size(105, 19);
            label7.TabIndex = 16;
            label7.Text = "Udgivelsesdato:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(498, 339);
            label8.Name = "label8";
            label8.Size = new Size(82, 19);
            label8.TabIndex = 17;
            label8.Text = "Image Path:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(520, 21);
            label9.Name = "label9";
            label9.Size = new Size(236, 40);
            label9.TabIndex = 18;
            label9.Text = "Tilføj ny film ved at udfylde\r\nde tomme felter og klik på \"Tilføj\"";
            // 
            // Movies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox_ImagePath);
            Controls.Add(textBox_PGRating);
            Controls.Add(textBox_Genre);
            Controls.Add(textBox_Length);
            Controls.Add(textBox_Title);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_add);
            Controls.Add(btn_back);
            Controls.Add(listBox1);
            Name = "Movies";
            Text = "Movies";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btn_back;
        private Button btn_add;
        private Label label1;
        private Label label2;
        private TextBox textBox_Title;
        private TextBox textBox_Length;
        private TextBox textBox_Genre;
        private TextBox textBox_PGRating;
        private TextBox textBox_ImagePath;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}