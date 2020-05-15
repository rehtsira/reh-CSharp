using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClasses
{
    //Hi Jeremy!


        //Aristher Manalaysay
        //Object-Oriented Programming
        //Jeremy Callinan
        //April 24, 2019
        //Classes
    class StudentInfo
    {
        Student st = new Student("Jon", "Azcona", "Male",3.8f);
        Student st2 = new Student( "Rayan", "Abedin","Male",3.9f);
        Student st3 = new Student( "Alexa", "Bachurski","Female",4.0f);
        Student st4 = new Student( "James", "Park", "Male",3.75f);
        Course co = new Course("Object-Oriented Programming", "Swarts");
        Course co1 = new Course("Biology", "Fisher");
        Course co2 = new Course("Comparative Politics", "Swarts");
    

        public void displayOutput()
        {
            st.StudentID = 1;
            st2.StudentID = 2;
            st3.StudentID = 3;
            st4.StudentID = 4;
            
            Console.WriteLine("Student ID: {0}. {1} {2}'s GPA is {4:F2}. Gender: {3}", st.StudentID,st.FirstName, st.LastName, st.Gender,st.GPA);
            Console.WriteLine("Student ID: {0}. {1} {2}'s GPA is {4:F2}. Gender: {3}", st2.StudentID,st2.FirstName, st2.LastName, st2.Gender,st2.GPA);
            Console.WriteLine("Student ID: {0}. {1} {2}'s GPA is {4:F2}. Gender: {3}", st3.StudentID, st3.FirstName, st3.LastName, st3.Gender,st3.GPA);
            Console.WriteLine("Student ID: {0}. {1} {2}'s GPA is {4:F2}. Gender: {3}", st4.StudentID, st4.FirstName, st4.LastName, st4.Gender,st4.GPA);

            Console.WriteLine("{0} {1} is taking {2} at {3}", st.FirstName, st.LastName, co2.Subject,co2.Location);
            Console.WriteLine("{0} {1} is taking {2} at {3}", st2.FirstName, st2.LastName, co.Subject, co.Location);
            Console.WriteLine("{0} {1} is taking {2} at {3}", st3.FirstName, st3.LastName, co.Subject, co.Location);
            Console.WriteLine("{0} {1} is taking {2} at {3}", st4.FirstName, st4.LastName, co1.Subject, co1.Location);


        }
    }
}
