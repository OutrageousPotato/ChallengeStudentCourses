using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Grades
    {
        public Course course { get; set; }
        public int grade { get; set; }




        /*public int grade
        {
            get { return grade; }
            set
            {
                if (value >= 0 && value <= 100)
                    grade = value;
                else
                    // learn how to generate an error message
                    throw new SystemException("Is this how you make an error message???");

            }
            
        }
        */
    }
}