using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
   public class GradeBook
   {
        // auto-implemented property CourseName implicitly creates an 
        // instance variable for this GradeBook's course name
        public string CourseName { get; set; }

        // auto-implemented property InstructorName implicitly creates an 
        // instance variable for this course's instructor
        public string InstructorName { get; set; }

        // constructor initializes automatic properties 
        // with two strings supplied as arguments
        public GradeBook(string course, string instructor)
        {
            CourseName = course; // set CourseName to course
            InstructorName = instructor; // set InstructorName to instructor
        } // end constructor

        // display a welcome message to the GradeBook user
        public void DisplayMessage()
        {
         // this statement uses automatic properties CourseName and 
         // InstructorName to get the name of the course and instructor
         Console.WriteLine("Welcome to the grade book for\n{0}!",
            CourseName);
         Console.WriteLine("This course is presented by: {0}",
            InstructorName);
        } // end method DisplayMessage
    } // end class GradeBook
}
