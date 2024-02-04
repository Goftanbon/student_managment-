using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_Task_Management
{
    internal class DBconn
    {
        //database connection
        string connstring;
        SqlConnection conn;

        //dataconnection 
        public SqlConnection openconn()
        {
            try
            {
                connstring = "Data Source=DESKTOP-NLM24L3\\MSSQLSERVER01;Initial Catalog=student_task_managment;" +
                    "Integrated Security=True";
                conn = new SqlConnection(connstring);
                conn.Open();


            }
            catch (Exception e)
            {
                if (MessageBox.Show(e.Message, "Database error in Database connection",
                    MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }
            return conn;

        }
        public void closeconn()
        {
            conn.Close();
        }


    }
}
