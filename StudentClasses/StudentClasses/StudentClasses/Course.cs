using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClasses
{
    class Course
    {
        public Course(string subject, string location)
        {
            Subject = subject;
            Location = location;
        }
  

 

        public string Subject { get; set; }
        public string Location { get; set; }
    }
    
}
