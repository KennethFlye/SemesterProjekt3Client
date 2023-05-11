namespace SemesterProjekt3Client
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.titleLabel = new System.Windows.Forms.Label();
            this.showingsList = new System.Windows.Forms.ListView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Film = new System.Windows.Forms.ColumnHeader();
            this.Sal = new System.Windows.Forms.ColumnHeader();
            this.Tid = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(32, 22);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(335, 15);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Current Showings [men på dansk [evt. det samme som i web]]";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // showingsList
            // 
            this.showingsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Film,
            this.Sal,
            this.Tid});
            this.showingsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.showingsList.Location = new System.Drawing.Point(32, 63);
            this.showingsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showingsList.Name = "showingsList";
            this.showingsList.Size = new System.Drawing.Size(195, 196);
            this.showingsList.TabIndex = 2;
            this.showingsList.UseCompatibleStateImageBehavior = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(388, 63);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.showingsList);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private ListView showingsList;
        private MonthCalendar monthCalendar1;
        private ColumnHeader Film;
        private ColumnHeader Sal;
        private ColumnHeader Tid;
    }
}
    
