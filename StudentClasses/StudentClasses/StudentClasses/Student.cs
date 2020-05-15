using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClasses
{
    class Student
    {
        public Student(string firstName, string lastName, string gender, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            GPA = gpa;
        }

        public Student(int id, string firstName, string lastName, string gender, float gpa)
        {
            StudentID = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = Gender;
            GPA = gpa;
        }

        public int StudentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public float GPA { get; set; }
    }
}
