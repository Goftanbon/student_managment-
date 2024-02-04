using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Student_Task_Management
{
    internal class Account
    {
        string username { get; set; }
        string password { get; set; }

        public int id ;
        

        //string validUsername = "Hello";
        //string validPassword = "World";
        //public Account(string user, string pass)
        //{
        //    username = user;
        //    password = pass;
        //}

        public bool Login(string username, string password, string role)
        {
            SqlConnection conn = new DBconn().openconn();
            bool istrue = false;
            string subj;

            //Validation

                string query = $"SELECT Password,id FROM {role} WHERE UserName = @UserName;";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@UserName", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // User found, compare passwords
                            string storedPassword = reader.GetString(0);
                            id = reader.GetInt32(1);
                            
                            


                        if (password == storedPassword)
                            {
                                Console.WriteLine("Login successful!");
                                return true;
                            }
                        }
                    }
                }

                Console.WriteLine("Login failed. Invalid username or password.");
                return false;
            }
        }

       

        //    public bool Change_password(string oldPassword,string newPassword)
        //    {
        //        if(oldPassword == validPassword)
        //        {
        //            validPassword = newPassword;
        //                return true; 
        //        }
        //        else
        //        {
        //            return false;
        //        }

        //    }
        //}
    }

