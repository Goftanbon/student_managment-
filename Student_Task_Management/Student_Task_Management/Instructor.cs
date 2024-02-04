using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Task_Management
{
    internal class Instructor
    {
        public int inst_id { get; set; }
        public string inst_name { get; set; }
        public string subject { get; set; }
        //login credentials
        public string userName { get; set; }
        public string password { get; set; }


        public bool succ = false;
        public Instructor() { }
        public Instructor(int inst_id)
        {
            this.inst_id = inst_id;
        }
        string status = "U";
        public void AddTaskAndAssign(string taskName, string taskDescription, DateTime dueDate, string fileName)
        {
            
            // Check if any of the required fields are empty
            if (string.IsNullOrEmpty(taskName) || string.IsNullOrEmpty(taskDescription) || string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            

            // Add task to the 'task' table
            int taskId = AddTask(taskName, taskDescription, dueDate, fileName, status);

            if (taskId > 0)
            {
                // Assign task to the instructor in the 'assigned_tasks' table
                
                AssignTask(this.inst_id, taskId);
                 succ = true;
            }
            else
            {
                MessageBox.Show("Task creation failed. Please check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        public int AddTask(string taskName, string taskDescription, DateTime dueDate, string fileName, string status)
        {
            SqlConnection conn = new DBconn().openconn();
            int taskId = -1; // Default value in case of failure
            

            try
            {
                // Check if any of the required fields are empty
                if (string.IsNullOrEmpty(taskName) || string.IsNullOrEmpty(taskDescription) || string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return taskId;
                }

                string insertTaskQuery = "INSERT INTO task (task_name, description, due_date, file_name,status) " +
                                         "VALUES (@TaskName, @TaskDescription, @DueDate, @FileName,@Status);" +
                                         "SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(insertTaskQuery, conn);

                // Use parameters to avoid SQL injection and handle data types correctly
                command.Parameters.AddWithValue("@TaskName", taskName);
                command.Parameters.AddWithValue("@TaskDescription", taskDescription);
                command.Parameters.AddWithValue("@DueDate", dueDate);
                command.Parameters.AddWithValue("@FileName", fileName);
                command.Parameters.AddWithValue("@Status",status);
                

                // ExecuteScalar is used to get the identity value of the inserted record
                taskId = Convert.ToInt32(command.ExecuteScalar());

                if (taskId > 0)
                {
                    MessageBox.Show($"Task successfully added ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add task", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return taskId;
        }

        private void AssignTask(int instId,int taskId)
        {
            List<int>stu = GetStudents(instId);

            using (SqlConnection conn = new DBconn().openconn())
            {
                foreach(int i in stu)
                {
                    string insertAssignedTaskQuery = "INSERT INTO assigned_tasks (stu_id,task_id) " +
                                                "VALUES (@stu_id, @TaskId);";
                    using (SqlCommand command = new SqlCommand(insertAssignedTaskQuery, conn))
                    {
                        command.Parameters.AddWithValue("@stu_id", i);
                        command.Parameters.AddWithValue("@TaskId", taskId);

                        int row = command.ExecuteNonQuery();
                        if (row > 0)
                        {
                            Console.WriteLine("Assigned Task");
                        }
                        else
                        {
                            Console.WriteLine("failed to Add Task");
                        }
                    }



                }

            }
            
           
        }
        public List<int> GetStudents(int instId)
        {
            List<int> studentIds = new List<int>();

            using(SqlConnection  conn = new DBconn().openconn()) 
            { 
                
                string query = "SELECT stu_id FROM assign_inst WHERE instu_id = @instId";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@instId", instId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int studentId = Convert.ToInt32(reader["stu_id"]);
                            studentIds.Add(studentId);
                        }
                    }
                }
            }

            return studentIds;
        }


    }
}































    //public bool IsInstructorValid(int instructorId)
    //    {
    //        inst.inst_id = instructorId;
    //        string str = "SELECT inst_id FROM instructor WHERE inst_id = @InstructorId";

//        using (SqlCommand cmd = new SqlCommand(str, conn))
//        {
//            // Add a parameter for the instructor ID
//            cmd.Parameters.AddWithValue("@InstructorId", inst.inst_id);

//            // Execute the query and check if any rows are returned
//            using (SqlDataReader reader = cmd.ExecuteReader())
//            {
//                // If the reader has rows, the instructor is valid
//                return reader.HasRows;
//            }
//        }
//    }
//        public List<Task> GetAssignnedTask(int instructorId, string taskName, string selectedFileName, DateTime selectedDueDate, string initialDescription)
//        {
//            int studentId = 0;
//            string sqlQuery = "SELECT st_id FROM assigned_task WHERE inst_id = @InstructorId;";
//            using (SqlCommand command = new SqlCommand(sqlQuery, conn))
//            {
//                // Add a parameter for the instructor ID
//                command.Parameters.AddWithValue("@InstructorId", instructorId);

//                // Execute the query and process the results
//                using (SqlDataReader reader = command.ExecuteReader())
//                {

//                    while (reader.Read())
//                    {
//                        // Access the "st_id" values
//                        studentId = Convert.ToInt32(reader);

//                    }
//                }

//                return new List<Task>
//                {
//                    new Task
//                    {
//                        stu_id = studentId,
//                        taskNAME = taskName,
//                        filename = selectedFileName,
//                        DateTime = selectedDueDate,
//                        description = initialDescription
//                    }
//                };
//            }
//        }
//    }
//}

//        public void evaluate_task()
//        {

//        }
//    }
//}
