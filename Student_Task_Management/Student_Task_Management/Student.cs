using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Task_Management
{
    internal class Student
    {
        //fileds of student
        public int st_id { get; set; }
        public string st_name { get; set; }
        public string section { get; set; }
        public string department { get; set; }
        //student login cridentailes 
        public string userName { get; set; }
        public string password { get; set; }



        public Student() { }
        public Student(int stu_id, string username)
        {
            this.st_id = stu_id;
            this.st_name = username;
        }
        


        public void submit_task()
        {

        }

        public void view_grade()
        {

        }
        private List<int> GetTaskIds(int stu_id)
        {
            List<int> task_id = new List<int>();
            using (SqlConnection conn = new DBconn().openconn())
            {
                string stm = "SELECT task_id FROM assigned_task WHERE stu_id = @stu_id";
                using (SqlCommand cmd = new SqlCommand(stm, conn))
                {
                    cmd.Parameters.AddWithValue("@stu_id", stu_id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int taskid = Convert.ToInt32(reader["stu_id"]);
                            task_id.Add(taskid);
                        }

                    }

                }
                return task_id;

            }
        }
        public SqlDataReader getTask(int stu_id)
        {
            List<int>tasksids = GetTaskIds(stu_id);
            SqlDataReader accRec = null;
            try
            {
                using (SqlConnection conn = new DBconn().openconn())
                {
                    foreach (int taskid in tasksids)
                    {
                        string stm = "SELECT * FROM task WHERE task_id = @task_id AND Status != 'D'";
                        using (SqlCommand command = new SqlCommand(stm, conn))
                        {
                            command.Parameters.AddWithValue("@task_id", taskid);
                            accRec = command.ExecuteReader();

                        }
                    }
                }
            }
            catch (Exception e) { MessageBox.Show( "Database Error" + MessageBoxButtons.OK + MessageBoxIcon.Error); }
            
            return accRec;
        }
    }
}

