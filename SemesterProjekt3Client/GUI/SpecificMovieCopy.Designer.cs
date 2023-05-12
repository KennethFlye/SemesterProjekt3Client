namespace SemesterProjekt3Client.GUI
{
    partial class SpecificMovieCopy
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
            label1 = new Label();
            label_movieCopyLanguage = new Label();
            label_movieCopy3D = new Label();
            label_movieCopyPrice = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox_updateMovieCopyLanguage = new TextBox();
            textBox_updateMovieCopyPrice = new TextBox();
            btn_back = new Button();
            btn_update = new Button();
            checkBox_updateIs3D = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 54);
            label1.Name = "label1";
            label1.Size = new Size(201, 25);
            label1.TabIndex = 0;
            label1.Text = "Filmkopi information";
            // 
            // label_movieCopyLanguage
            // 
            label_movieCopyLanguage.AutoSize = true;
            label_movieCopyLanguage.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_movieCopyLanguage.Location = new Point(42, 107);
            label_movieCopyLanguage.Name = "label_movieCopyLanguage";
            label_movieCopyLanguage.Size = new Size(52, 19);
            label_movieCopyLanguage.TabIndex = 1;
            label_movieCopyLanguage.Text = "Sprog: ";
            // 
            // label_movieCopy3D
            // 
            label_movieCopy3D.AutoSize = true;
            label_movieCopy3D.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_movieCopy3D.Location = new Point(42, 146);
            label_movieCopy3D.Name = "label_movieCopy3D";
            label_movieCopy3D.Size = new Size(34, 19);
            label_movieCopy3D.TabIndex = 2;
            label_movieCopy3D.Text = "3D: ";
            // 
            // label_movieCopyPrice
            // 
            label_movieCopyPrice.AutoSize = true;
            label_movieCopyPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_movieCopyPrice.Location = new Point(42, 184);
            label_movieCopyPrice.Name = "label_movieCopyPrice";
            label_movieCopyPrice.Size = new Size(38, 19);
            label_movieCopyPrice.TabIndex = 3;
            label_movieCopyPrice.Text = "Pris: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(324, 39);
            label5.Name = "label5";
            label5.Size = new Size(333, 40);
            label5.TabIndex = 4;
            label5.Text = "Udfyld attributer du ønsker at opdatere\r\nog klik \"Opdater\" for at opdatere denne filmkopi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(368, 109);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 5;
            label6.Text = "Nyt sprog:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(388, 148);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 6;
            label7.Text = "Ny 3D:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(310, 186);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 7;
            label8.Text = "Ny pris (Kun hele tal):";
            // 
            // textBox_updateMovieCopyLanguage
            // 
            textBox_updateMovieCopyLanguage.Location = new Point(436, 106);
            textBox_updateMovieCopyLanguage.Name = "textBox_updateMovieCopyLanguage";
            textBox_updateMovieCopyLanguage.Size = new Size(100, 23);
            textBox_updateMovieCopyLanguage.TabIndex = 8;
            // 
            // textBox_updateMovieCopyPrice
            // 
            textBox_updateMovieCopyPrice.Location = new Point(436, 183);
            textBox_updateMovieCopyPrice.Name = "textBox_updateMovieCopyPrice";
            textBox_updateMovieCopyPrice.Size = new Size(100, 23);
            textBox_updateMovieCopyPrice.TabIndex = 10;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(12, 277);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(87, 31);
            btn_back.TabIndex = 11;
            btn_back.Text = "Tilbage";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(436, 224);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(83, 32);
            btn_update.TabIndex = 12;
            btn_update.Text = "Opdater";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // checkBox_updateIs3D
            // 
            checkBox_updateIs3D.AutoSize = true;
            checkBox_updateIs3D.Location = new Point(436, 147);
            checkBox_updateIs3D.Name = "checkBox_updateIs3D";
            checkBox_updateIs3D.Size = new Size(15, 14);
            checkBox_updateIs3D.TabIndex = 13;
            checkBox_updateIs3D.UseVisualStyleBackColor = true;
            // 
            // SpecificMovieCopy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 320);
            Controls.Add(checkBox_updateIs3D);
            Controls.Add(btn_update);
            Controls.Add(btn_back);
            Controls.Add(textBox_updateMovieCopyPrice);
            Controls.Add(textBox_updateMovieCopyLanguage);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label_movieCopyPrice);
            Controls.Add(label_movieCopy3D);
            Controls.Add(label_movieCopyLanguage);
            Controls.Add(label1);
            Name = "SpecificMovieCopy";
            Text = "SpecificMovieCopy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_movieCopyLanguage;
        private Label label_movieCopy3D;
        private Label label_movieCopyPrice;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox_updateMovieCopyLanguage;
        private TextBox textBox_updateMovieCopyPrice;
        private Button btn_back;
        private Button btn_update;
        private CheckBox checkBox_updateIs3D;
    }
}