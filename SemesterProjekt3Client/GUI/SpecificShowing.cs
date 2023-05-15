﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SemesterProjekt3Client.Model;

namespace SemesterProjekt3Client.GUI
{
    public partial class SpecificShowing : Form
    {
        Showing showing;
        public SpecificShowing(Showing showing)
        {
            InitializeComponent();
            this.showing = showing;
            //AssignInformationToControls(showing);
        }

        public SpecificShowing()
        {
            InitializeComponent();
            showing = new Showing();
        }

        private void AssignInformationToControls(Showing s)
        {
            try
            {
                textBoxShowingId.Text = showing.ShowingId.ToString();

            }
            catch (Exception)
            {

            }
            dateTimePicker1.Value = showing.startTime;
            checkBoxIsKidFriendly.Checked = showing.IsKidFriendly;
            
            //Showroom
            //MovieCopy
        }

        private void AssignNewValuesToShowing(Showing s)
        {
            try
            {
                showing.ShowingId = int.Parse(textBoxShowingId.Text);
                showing.startTime = dateTimePicker1.Value;
                showing.IsKidFriendly = checkBoxIsKidFriendly.Checked;

                ///showroom get from combobox
                
                comboBoxShowRoom.Items.Add(showing.ShowRoom);
                //showing.ShowRoom = comboBoxShowRoom.Items[0].


            }catch (Exception){
                MessageBox.Show("Id must be an integer value!");
            }

            showing.startTime = dateTimePicker1.Value;
            showing.IsKidFriendly = checkBoxIsKidFriendly.Checked;

            //Showroom
            //MovieCopy
        }



        private void SpecificShowing_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AssignNewValuesToShowing(showing);
            //Other method to post the data change

        }

        private void SpecificShowing_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
