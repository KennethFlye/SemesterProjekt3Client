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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBoxShowingId = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelIsKidFriendly = new System.Windows.Forms.Label();
            this.labelShowRoom = new System.Windows.Forms.Label();
            this.labelMovieCopy = new System.Windows.Forms.Label();
            this.checkBoxIsKidFriendly = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMovieCopy = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(293, 251);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Opdater";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textBoxShowingId
            // 
            this.textBoxShowingId.Location = new System.Drawing.Point(137, 12);
            this.textBoxShowingId.Name = "textBoxShowingId";
            this.textBoxShowingId.Size = new System.Drawing.Size(125, 27);
            this.textBoxShowingId.TabIndex = 1;
            this.textBoxShowingId.Text = "Id";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(21, 19);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 20);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(21, 60);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(73, 20);
            this.labelStartTime.TabIndex = 3;
            this.labelStartTime.Text = "StartTime";
            // 
            // labelIsKidFriendly
            // 
            this.labelIsKidFriendly.AutoSize = true;
            this.labelIsKidFriendly.Location = new System.Drawing.Point(21, 101);
            this.labelIsKidFriendly.Name = "labelIsKidFriendly";
            this.labelIsKidFriendly.Size = new System.Drawing.Size(93, 20);
            this.labelIsKidFriendly.TabIndex = 4;
            this.labelIsKidFriendly.Text = "IsKidFriendly";
            // 
            // labelShowRoom
            // 
            this.labelShowRoom.AutoSize = true;
            this.labelShowRoom.Location = new System.Drawing.Point(21, 152);
            this.labelShowRoom.Name = "labelShowRoom";
            this.labelShowRoom.Size = new System.Drawing.Size(85, 20);
            this.labelShowRoom.TabIndex = 5;
            this.labelShowRoom.Text = "ShowRoom";
            // 
            // labelMovieCopy
            // 
            this.labelMovieCopy.AutoSize = true;
            this.labelMovieCopy.Location = new System.Drawing.Point(21, 204);
            this.labelMovieCopy.Name = "labelMovieCopy";
            this.labelMovieCopy.Size = new System.Drawing.Size(84, 20);
            this.labelMovieCopy.TabIndex = 6;
            this.labelMovieCopy.Text = "MovieCopy";
            // 
            // checkBoxIsKidFriendly
            // 
            this.checkBoxIsKidFriendly.AutoSize = true;
            this.checkBoxIsKidFriendly.Location = new System.Drawing.Point(137, 104);
            this.checkBoxIsKidFriendly.Name = "checkBoxIsKidFriendly";
            this.checkBoxIsKidFriendly.Size = new System.Drawing.Size(18, 17);
            this.checkBoxIsKidFriendly.TabIndex = 7;
            this.checkBoxIsKidFriendly.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // comboBoxMovieCopy
            // 
            this.comboBoxMovieCopy.FormattingEnabled = true;
            this.comboBoxMovieCopy.Location = new System.Drawing.Point(137, 204);
            this.comboBoxMovieCopy.Name = "comboBoxMovieCopy";
            this.comboBoxMovieCopy.Size = new System.Drawing.Size(151, 28);
            this.comboBoxMovieCopy.TabIndex = 9;
            // 
            // SpecificShowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 300);
            this.Controls.Add(this.comboBoxMovieCopy);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBoxIsKidFriendly);
            this.Controls.Add(this.labelMovieCopy);
            this.Controls.Add(this.labelShowRoom);
            this.Controls.Add(this.labelIsKidFriendly);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxShowingId);
            this.Controls.Add(this.btnUpdate);
            this.Name = "SpecificShowing";
            this.Text = "SpecificShowing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpecificShowing_FormClosing);
            this.Load += new System.EventHandler(this.SpecificShowing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}