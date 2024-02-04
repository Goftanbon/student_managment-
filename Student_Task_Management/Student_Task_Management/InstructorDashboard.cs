using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace Student_Task_Management
{
    public partial class InstructorDashboard : Form
    {
        //calling instructor calss object
        int id;
        public InstructorDashboard(int id)
        {
            InitializeComponent();
            this.id = id;

        }

        private void userPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void instSubmitButton_Click(object sender, EventArgs e)
        {
            //Validate input and save data to database
            //....

           // Clear the input fields;
            //taskNameTextBox.Text = "";
            //dueDateTimePicker.Value = DateTime.Now;
            //descriptonRichTextBox.Text = "";
            Instructor instructor = new Instructor(id);
            SqlConnection conn = new DBconn().openconn();

            
            instructor.AddTaskAndAssign(taskNameTextBox.Text,descriptonRichTextBox.Text , dueDateTimePicker.Value, selectFileTextBox.Text);
            if(instructor.succ == true) 
            {
                taskNameTextBox.Text = "";
                descriptonRichTextBox.Text = "";
                selectFileTextBox.Text = "";
            }


        }

        private void InstructorDashboard_Load(object sender, EventArgs e)
        {


        }
        
        private void addTasksButton_Click(object sender, EventArgs e)
        {
            addTasksPanel.Visible = true;
            submittedTasksPanel.Visible = false;

            submittedTasksButton.ForeColor = Color.FromArgb(64, 64, 64);
            addTasksButton.ForeColor = Color.RoyalBlue;
        }

        private void submittedTasksButton_Click(object sender, EventArgs e)
        {
            addTasksPanel.Visible = false;
            submittedTasksPanel.Visible = true;

            submittedTasksButton.ForeColor = Color.RoyalBlue;
            addTasksButton.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void taskNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog();
            if (instOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectFileTextBox.Text = instOpenFileDialog.FileName;
            }
            
        }

        private void instructorLogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm strt = new StartForm();
            strt.Show();
            //this.Close();

        }

        private void instructorHeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void instHdrNameDisLabel_Click(object sender, EventArgs e)
        {
           


        }

        private void instHdrSubjDisLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void instHdrIdDisLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
