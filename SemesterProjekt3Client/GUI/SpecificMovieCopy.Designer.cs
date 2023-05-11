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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
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
            label6.Location = new Point(389, 109);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 5;
            label6.Text = "Sprog:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(406, 148);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 6;
            label7.Text = "3D:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(401, 186);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 7;
            label8.Text = "Pris:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(436, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(436, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(436, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 10;
            // 
            // SpecificMovieCopy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 320);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}