using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Task_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            userTextBox.Focus();
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            Account acct = new Account();
            string role = roleComboBox.SelectedItem.ToString();
            bool result = acct.Login(userTextBox.Text, passTextBox.Text,role);
          
            
            //checking user entry's 

            if (string.IsNullOrEmpty(userTextBox.Text))
                    {
                             userErrorLabel.Text = "*Username is required!";
                    }

                    else if (string.IsNullOrEmpty(passTextBox.Text))
                    {
                             passErrorLabel.Text = "*Password is required";
                    }

                    else if (string.IsNullOrEmpty(roleComboBox.Text))
                    {
                             roleErrorLabel.Text = "*Role is required";
                    }
                    else
                    {
                      if (result)
                      {
                          
                          switch (role)
                          {
                            case "Student":
                                this.Hide();
                                StudentDashboard studentDashboard = new StudentDashboard();

                                studentDashboard.ShowDialog();
                                this.Close();
                                break;
                            case "Instructor":
                                this.Hide();
                                Instructor instructor  = new Instructor();
                                InstructorDashboard instructorDashboard = new InstructorDashboard(acct.id);
                            instructorDashboard.instHdrIdDisLabel.Text = acct.id.ToString();
                            //instHdrNameDisLabel.Text = instructor.inst_name;
                            //instHdrIdDisLabel.Text = instructor.inst_id.ToString();
                            instructorDashboard.ShowDialog();
                                //this.Close();
                                break;
                            case "Admin":
                                this.Hide();
                                AdminDashboard admin = new AdminDashboard();

                                admin.ShowDialog();
                                //this.Close();
                                break;
                          }
                       
                }
                            else
                            {
                               validationErrorLabel.Text = "Incorrect username or password. Please try again!";
                                     userTextBox.Clear();
                                     passTextBox.Clear();
                            }
            }
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            userErrorLabel.Text = "";
            
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            passErrorLabel.Text = "";
        }

        private void roleComboBox_TextChanged(object sender, EventArgs e)
        {
            roleErrorLabel.Text = "";
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }

}
   
