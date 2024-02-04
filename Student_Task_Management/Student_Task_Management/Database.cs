using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syste

namespace Student_Task_Management
{
    internal class Database
    {

        string connString;
        
        public Database()
        {

        }
        public SqlConnection openConnection()
        {
            try
            {
                connString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;" +
                    "Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;" +
                    "Application Intent=ReadWrite;Multi Subnet Failover=False";
                conn = new SqlConnection(connString);

            }




    }
}
