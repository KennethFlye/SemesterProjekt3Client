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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.titleLabel = new System.Windows.Forms.Label();
            this.showingsList = new System.Windows.Forms.ListView();
            this.Film = new System.Windows.Forms.ColumnHeader();
            this.Sal = new System.Windows.Forms.ColumnHeader();
            this.Tid = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            listViewItem2});
            this.showingsList.Location = new System.Drawing.Point(32, 63);
            this.showingsList.Margin = new System.Windows.Forms.Padding(2);
            this.showingsList.Name = "showingsList";
            this.showingsList.Size = new System.Drawing.Size(195, 196);
            this.showingsList.TabIndex = 2;
            this.showingsList.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Opret [Showing]\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(262, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 270);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showingsList);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private ListView showingsList;
        private ColumnHeader Film;
        private ColumnHeader Sal;
        private ColumnHeader Tid;
        private Button button1;
        private DateTimePicker dateTimePicker1;
    }
}
    
