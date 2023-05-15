using SemesterProjekt3Client.Controllers;
using SemesterProjekt3Client.Model;

namespace SemesterProjekt3Client
{
    partial class ShowingIndexForm
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.titleLabel = new System.Windows.Forms.Label();
            this.showingsList = new System.Windows.Forms.ListView();
            this.Film = new System.Windows.Forms.ColumnHeader();
            this.Sal = new System.Windows.Forms.ColumnHeader();
            this.Tid = new System.Windows.Forms.ColumnHeader();
            this.createButton = new System.Windows.Forms.Button();
            this.movieComboBox = new System.Windows.Forms.ComboBox();
            this.kidCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowRoomComboBox = new System.Windows.Forms.ComboBox();
            this.movieLabel = new System.Windows.Forms.Label();
            this.ShowRoomLabel = new System.Windows.Forms.Label();
            this.getButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.StopLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(46, 37);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(503, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Current Showings [men på dansk [evt. det samme som i web]]";
            // 
            // showingsList
            // 
            this.showingsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Film,
            this.Sal,
            this.Tid});
            this.showingsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.showingsList.Location = new System.Drawing.Point(46, 105);
            this.showingsList.Name = "showingsList";
            this.showingsList.Size = new System.Drawing.Size(530, 411);
            this.showingsList.TabIndex = 2;
            this.showingsList.UseCompatibleStateImageBehavior = false;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(607, 135);
            this.createButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(204, 38);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Opret [Showing]\r\n";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // movieComboBox
            // 
            this.movieComboBox.FormattingEnabled = true;
            this.movieComboBox.Location = new System.Drawing.Point(607, 262);
            this.movieComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.movieComboBox.Name = "movieComboBox";
            this.movieComboBox.Size = new System.Drawing.Size(203, 33);
            this.movieComboBox.TabIndex = 6;
            // 
            // kidCheckBox
            // 
            this.kidCheckBox.AutoSize = true;
            this.kidCheckBox.Location = new System.Drawing.Point(607, 403);
            this.kidCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kidCheckBox.Name = "kidCheckBox";
            this.kidCheckBox.Size = new System.Drawing.Size(215, 29);
            this.kidCheckBox.TabIndex = 7;
            this.kidCheckBox.Text = "Børnevenlig forestlling";
            this.kidCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowRoomComboBox
            // 
            this.ShowRoomComboBox.FormattingEnabled = true;
            this.ShowRoomComboBox.Location = new System.Drawing.Point(607, 338);
            this.ShowRoomComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowRoomComboBox.Name = "ShowRoomComboBox";
            this.ShowRoomComboBox.Size = new System.Drawing.Size(203, 33);
            this.ShowRoomComboBox.TabIndex = 8;
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Location = new System.Drawing.Point(607, 232);
            this.movieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(45, 25);
            this.movieLabel.TabIndex = 9;
            this.movieLabel.Text = "Film";
            // 
            // ShowRoomLabel
            // 
            this.ShowRoomLabel.AutoSize = true;
            this.ShowRoomLabel.Location = new System.Drawing.Point(607, 308);
            this.ShowRoomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShowRoomLabel.Name = "ShowRoomLabel";
            this.ShowRoomLabel.Size = new System.Drawing.Size(35, 25);
            this.ShowRoomLabel.TabIndex = 10;
            this.ShowRoomLabel.Text = "Sal";
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(578, 14);
            this.getButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(174, 38);
            this.getButton.TabIndex = 11;
            this.getButton.Text = "GET EM ALL";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(607, 198);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 31);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // StopLabel
            // 
            this.StopLabel.AutoSize = true;
            this.StopLabel.Location = new System.Drawing.Point(1025, 699);
            this.StopLabel.Name = "StopLabel";
            this.StopLabel.Size = new System.Drawing.Size(147, 25);
            this.StopLabel.TabIndex = 13;
            this.StopLabel.Text = "Lad vær med det";
            // 
            // ShowingIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 605);
            this.Controls.Add(this.StopLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.ShowRoomLabel);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.ShowRoomComboBox);
            this.Controls.Add(this.kidCheckBox);
            this.Controls.Add(this.movieComboBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.showingsList);
            this.Controls.Add(this.titleLabel);
            this.Name = "ShowingIndexForm";
            this.Text = "Filmvisninger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private ListView showingsList;
        private ColumnHeader Film;
        private ColumnHeader Sal;
        private ColumnHeader Tid;
        private Button createButton;
        private ComboBox movieComboBox;
        private CheckBox kidCheckBox;
        private ComboBox ShowRoomComboBox;
        private Label movieLabel;
        private Label ShowRoomLabel;
        private Button getButton;
        private DateTimePicker dateTimePicker1;
        private Label StopLabel;
    }
}
    
