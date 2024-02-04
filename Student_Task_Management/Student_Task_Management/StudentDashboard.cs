using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Task_Management
{
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();

        }

        private void InstructorPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void evaluatedTskLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void assignedTasksButton_Click(object sender, EventArgs e)
        {
            assignedTsksPanel.Visible = true;
            evaluatedTasksPanel.Visible = false;

            evaluatedTasksButton.ForeColor = Color.FromArgb(64, 64, 64);
            assignedTasksButton.ForeColor = Color.RoyalBlue;
        }

        private void evaluatedTasksButton_Click(object sender, EventArgs e)
        {
            assignedTsksPanel.Visible = false;
            evaluatedTasksPanel.Visible = true;

            evaluatedTasksButton.ForeColor = Color.RoyalBlue;
            assignedTasksButton.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm strt = new StartForm();
            strt.Show();
            //this.Close();



        }

        private void StudentDashboard_Click(object sender, EventArgs e)
        {

        }

        private void evaluatedTasksPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void evaluatedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
