using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Web;
using System.Drawing.Text;


namespace Student_Task_Management
{
    internal class Admin
    {
        int ad_id = 123;
        string ad_name = "adimn";




        public Admin() { }



        public void register_student(int stu_id, string stu_name, string section, string Dep, string username, string pass)
        {
            //callling connection 
            SqlConnection conn = new DBconn().openconn();
            Student student = new Student();
            //intalizing student properies through admin 
            student.st_name = stu_name;
            student.section = section;
            student.st_id = stu_id;
            student.department = Dep;
            student.userName = username;
            student.password = pass;

            string stm = string.Format("INSERT INTO student (id,student_name,username,department,section,password) " +
                $"VALUES('{student.st_id}','{student.st_name}','{student.userName}','{student.department}','{student.section}','{student.password}')");

            SqlCommand cmd = new SqlCommand(stm, conn);

            int rowaffected = cmd.ExecuteNonQuery();
            if (rowaffected > 0)
            {
                MessageBox.Show("Succesfully added" );
            }
            conn.Close();
        }

        public void register_instructor(int inst_id, string inst_name, string courese, string username, string pass)
        {

            //calling conn
            SqlConnection conn = new DBconn().openconn();

            Instructor instructor = new Instructor();
            //intalizing student properies through admin 
            instructor.inst_id = inst_id;
            instructor.inst_name = inst_name;
            instructor.subject = courese;
            instructor.userName = username;
            instructor.password = pass;




            string stm = string.Format("INSERT INTO instructor (id,instructor_name,course,username,password) " +
                $"VALUES('{instructor.inst_id}','{instructor.inst_name}','{instructor.subject}','{instructor.userName}','{instructor.password}')");

            SqlCommand cmd = new SqlCommand(stm, conn);

            int rowaffected = cmd.ExecuteNonQuery();
            if (rowaffected > 0)
            {
                MessageBox.Show($"Task successfully added ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            conn.Close();
        }

        public void AssignInstructor(int instructorId, string section)
        {
            //checking in valid insertion
            if (instructorId == 0 || string.IsNullOrEmpty(section))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Calling conn
            SqlConnection conn = new DBconn().openconn();

            try
            {
                // First, check whether the instructor is found in the database with its ID
                string checkInstructorQuery = "SELECT COUNT(*) FROM instructor WHERE id = @InstructorId;";

                SqlCommand checkCommand = new SqlCommand(checkInstructorQuery, conn);
                checkCommand.Parameters.AddWithValue("@InstructorId", instructorId);

                int instructorCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (instructorCount > 0)
                {
                    // If the instructor is found, proceed to insert into assign_inst table
                    string insertAssignQuery = "INSERT INTO assign_inst (stu_id, instu_id) " +
                                               "SELECT student.id, instructor.id " +
                                               "FROM student, instructor " +
                                               "WHERE student.section = @Section AND instructor.id = @InstructorId;";

                    SqlCommand insertCommand = new SqlCommand(insertAssignQuery, conn);
                    insertCommand.Parameters.AddWithValue("@Section", section);
                    insertCommand.Parameters.AddWithValue("@InstructorId", instructorId);

                    int rowsAffected = insertCommand.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Task successfully added ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert values into assign_inst table");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Teacher ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public void change_instructor(int inst_id, int new_id,string sect)
        {
            SqlConnection conn = new DBconn().openconn();
            Instructor instructor = new Instructor();
            Student student = new Student();
            instructor.inst_id = inst_id;
            student.section = sect;
            List<int> sudent = getstudbysection(sect);
            try
            {
                //checking the inserted instu id is exit 
                if(IsInstFound(inst_id)== true)
                {


                    foreach (int s in sudent)
                    {
                        string stm = "UPDATE assign_inst SET instu_id = @new_id WHERE stu_id = @stuid AND instu_id = @oldid";
                        using (SqlCommand command = new SqlCommand(stm, conn))
                        {
                            command.Parameters.AddWithValue("@new_id",new_id);
                            command.Parameters.AddWithValue("@stuid",s);
                            command.Parameters.AddWithValue("@oldid",inst_id);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"Task successfully changed ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                          
                        }
                    }

                }

               
            }

            catch (SqlException ex)
            {
                //// Handle the exception
                Console.WriteLine($"Error: {ex.Message}");
                MessageBox.Show("Invalid");
            }

           conn.Close();


        }
        private List<int> getstudbysection(string section)
        {

            List<int> studentIds = new List<int>();

            using (SqlConnection conn = new DBconn().openconn())
            {

                string query = "SELECT id FROM student WHERE section = @section";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@section", section);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int studentId = Convert.ToInt32(reader["id"]);
                            studentIds.Add(studentId);
                        }
                    }
                }
            }

            return studentIds;
        }
    


        
        private bool IsInstFound(int oldid)
        {
            //we assume there is instu in database set out flag false
            bool exit = false;

            string stm = "SELECT id FROM instructor WHERE id = @instuid ";
            using(SqlConnection connection = new DBconn().openconn())
            {
                using(SqlCommand command = new SqlCommand(stm, connection))
                {
                    command.Parameters.AddWithValue("instuid", oldid);
                   int row = Convert.ToInt32(command.ExecuteScalar());  
                    //now checking wherter the instu found 
                    if(row > 0)
                    {
                        return  exit = true;
                    }
                }
            }
                
            return exit;


        }
    }

}





