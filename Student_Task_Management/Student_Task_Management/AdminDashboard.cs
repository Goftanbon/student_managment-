using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Task_Management
{
    public partial class AdminDashboard : Form
    {
        //calling admin object 
        Admin ad = new Admin();
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void instRegUserLabel_Click(object sender, EventArgs e)
        {


        }

        private void assignInstructorsButton_Click(object sender, EventArgs e)
        {
            studRegPanel.Visible = false;
            instRegPanel.Visible = false;
            instAssignPanel.Visible = true;
            changePanel.Visible = false;

            registerStudentsButton.ForeColor = Color.FromArgb(64, 64, 64);
            assignInstructorsButton.ForeColor = Color.RoyalBlue;
            registerInstructorButton.ForeColor = Color.FromArgb(64, 64, 64);
            //adChangeBtn.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void instRegButton_Click(object sender, EventArgs e)
        {
            ad.register_instructor(Convert.ToInt32(instRegIDTextBox.Text), instRegNameTextBox.Text,instRegCourseTextBox.Text, instRegUserTextBox.Text, instRegPassTextBox.Text);

        }

        private void instRegButton_Click_1(object sender, EventArgs e)
        {
            ad.register_instructor(Convert.ToInt32(instRegIDTextBox.Text), instRegNameTextBox.Text, instRegCourseTextBox.Text, instRegUserTextBox.Text, instRegPassTextBox.Text);


        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void studRegisterButton_Click(object sender, EventArgs e)
        {
            Student student = new Student(); 
            ad.register_student(Convert.ToInt32(studRegIDTextBox.Text), studRegNameTextBox.Text, studRegSectionTextBox.Text, studRegDeptTextBox.Text, studRegUserTextBox.Text, studRegPassTextBox.Text);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ad.AssignInstructor(Convert.ToInt32(instAssignIDTextBox.Text), instAssignSectionTextBox.Text);
        }

        

        private void instructorLogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm strt = new StartForm();
            strt.Show();
            //this.Close();
        }

        private void instAssignPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerInstructorButton_Click_1(object sender, EventArgs e)
        {
            studRegPanel.Visible = false;
            instRegPanel.Visible = true;
            instAssignPanel.Visible = false;
            changePanel.Visible = false;


            registerInstructorButton.ForeColor = Color.RoyalBlue;
            assignInstructorsButton.ForeColor = Color.FromArgb(64, 64, 64);
            registerStudentsButton.ForeColor = Color.FromArgb(64, 64, 64);
            //adChangeBtn.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void registerStudentsButton_Click_1(object sender, EventArgs e)
        {
            studRegPanel.Visible = true;
            instRegPanel.Visible = false;
            instAssignPanel.Visible = false;
            changePanel.Visible = false;

            registerInstructorButton.ForeColor = Color.FromArgb(64, 64, 64);
            assignInstructorsButton.ForeColor = Color.FromArgb(64, 64, 64);
            registerStudentsButton.ForeColor = Color.RoyalBlue;
            //adChangeBtn.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void studRegIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studRegIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void NewInstTextBox_Click(object sender, EventArgs e)
        {

        }

        private void studBtnPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            ad.change_instructor(Convert.ToInt32(OldInstTextBox.Text),Convert.ToInt32(NewInstTextBox.Text), ChangeSectionTextBox.Text);
        }

       // private void adChangeBtn_Click(object sender, EventArgs e)
        //{
        //    studRegPanel.Visible = false;
        //    instRegPanel.Visible = false;
        //    instAssignPanel.Visible = false;
        //    //adChangeBtn.Visible = true;

        //    registerInstructorButton.ForeColor = Color.FromArgb(64, 64, 64);
        //    assignInstructorsButton.ForeColor = Color.FromArgb(64, 64, 64);
        //    registerStudentsButton.ForeColor = Color.FromArgb(64, 64, 64);
        //    //adChangeBtn.ForeColor = Color.RoyalBlue;
        //}

        private void changePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changeInstBtn_Click(object sender, EventArgs e)
        {
        studRegPanel.Visible = false;
        instRegPanel.Visible = false;
        instAssignPanel.Visible = false;
        changePanel.Visible = true;
        

        registerInstructorButton.ForeColor = Color.FromArgb(64, 64, 64);
        assignInstructorsButton.ForeColor = Color.FromArgb(64, 64, 64);
        registerStudentsButton.ForeColor = Color.FromArgb(64, 64, 64);
        //adChangeBtn.ForeColor = Color.RoyalBlue;
    }

        private void adAssignBtn_Click(object sender, EventArgs e)
        {
            ad.AssignInstructor(Convert.ToInt32(instAssignIDTextBox.Text), instAssignSectionTextBox.Text);
        }
    }
    
}
