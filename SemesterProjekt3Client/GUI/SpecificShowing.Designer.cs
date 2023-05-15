namespace SemesterProjekt3Client.GUI
{
    partial class SpecificShowing
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
            btnUpdate = new Button();
            textBoxShowingId = new TextBox();
            labelID = new Label();
            labelStartTime = new Label();
            labelIsKidFriendly = new Label();
            labelShowRoom = new Label();
            labelMovieCopy = new Label();
            checkBoxIsKidFriendly = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            comboBoxMovieCopy = new ComboBox();
            comboBoxShowRoom = new ComboBox();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(256, 188);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Opdater";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // textBoxShowingId
            // 
            textBoxShowingId.Location = new Point(120, 9);
            textBoxShowingId.Margin = new Padding(3, 2, 3, 2);
            textBoxShowingId.Name = "textBoxShowingId";
            textBoxShowingId.Size = new Size(110, 23);
            textBoxShowingId.TabIndex = 1;
            textBoxShowingId.Text = "Id";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(18, 14);
            labelID.Name = "labelID";
            labelID.Size = new Size(18, 15);
            labelID.TabIndex = 2;
            labelID.Text = "ID";
            // 
            // labelStartTime
            // 
            labelStartTime.AutoSize = true;
            labelStartTime.Location = new Point(18, 45);
            labelStartTime.Name = "labelStartTime";
            labelStartTime.Size = new Size(57, 15);
            labelStartTime.TabIndex = 3;
            labelStartTime.Text = "StartTime";
            // 
            // labelIsKidFriendly
            // 
            labelIsKidFriendly.AutoSize = true;
            labelIsKidFriendly.Location = new Point(18, 76);
            labelIsKidFriendly.Name = "labelIsKidFriendly";
            labelIsKidFriendly.Size = new Size(74, 15);
            labelIsKidFriendly.TabIndex = 4;
            labelIsKidFriendly.Text = "IsKidFriendly";
            // 
            // labelShowRoom
            // 
            labelShowRoom.AutoSize = true;
            labelShowRoom.Location = new Point(18, 114);
            labelShowRoom.Name = "labelShowRoom";
            labelShowRoom.Size = new Size(68, 15);
            labelShowRoom.TabIndex = 5;
            labelShowRoom.Text = "ShowRoom";
            // 
            // labelMovieCopy
            // 
            labelMovieCopy.AutoSize = true;
            labelMovieCopy.Location = new Point(18, 153);
            labelMovieCopy.Name = "labelMovieCopy";
            labelMovieCopy.Size = new Size(68, 15);
            labelMovieCopy.TabIndex = 6;
            labelMovieCopy.Text = "MovieCopy";
            // 
            // checkBoxIsKidFriendly
            // 
            checkBoxIsKidFriendly.AutoSize = true;
            checkBoxIsKidFriendly.Location = new Point(120, 78);
            checkBoxIsKidFriendly.Margin = new Padding(3, 2, 3, 2);
            checkBoxIsKidFriendly.Name = "checkBoxIsKidFriendly";
            checkBoxIsKidFriendly.Size = new Size(15, 14);
            checkBoxIsKidFriendly.TabIndex = 7;
            checkBoxIsKidFriendly.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(120, 45);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // comboBoxMovieCopy
            // 
            comboBoxMovieCopy.FormattingEnabled = true;
            comboBoxMovieCopy.Location = new Point(120, 153);
            comboBoxMovieCopy.Margin = new Padding(3, 2, 3, 2);
            comboBoxMovieCopy.Name = "comboBoxMovieCopy";
            comboBoxMovieCopy.Size = new Size(133, 23);
            comboBoxMovieCopy.TabIndex = 9;
            // 
            // comboBoxShowRoom
            // 
            comboBoxShowRoom.FormattingEnabled = true;
            comboBoxShowRoom.Location = new Point(120, 114);
            comboBoxShowRoom.Margin = new Padding(3, 2, 3, 2);
            comboBoxShowRoom.Name = "comboBoxShowRoom";
            comboBoxShowRoom.Size = new Size(133, 23);
            comboBoxShowRoom.TabIndex = 10;
            // 
            // SpecificShowing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 225);
            Controls.Add(comboBoxShowRoom);
            Controls.Add(comboBoxMovieCopy);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkBoxIsKidFriendly);
            Controls.Add(labelMovieCopy);
            Controls.Add(labelShowRoom);
            Controls.Add(labelIsKidFriendly);
            Controls.Add(labelStartTime);
            Controls.Add(labelID);
            Controls.Add(textBoxShowingId);
            Controls.Add(btnUpdate);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SpecificShowing";
            Text = "SpecificShowing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private TextBox textBoxShowingId;
        private Label labelID;
        private Label labelStartTime;
        private Label labelIsKidFriendly;
        private Label labelShowRoom;
        private Label labelMovieCopy;
        private CheckBox checkBoxIsKidFriendly;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxMovieCopy;
        private ComboBox comboBoxShowRoom;
    }
}