using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Task_Management
{
    internal class Task
    {
        public string taskNAME { get; set; }
        public string taskID { get; set; }
        public string filename { get; set; }
        public DateTime DateTime { get; set; }
        public string description { get; set; } 
        //the id of studet which the task is assigned to too 
        public int stu_id { get; set; }



        public Task() { }

    }
}
