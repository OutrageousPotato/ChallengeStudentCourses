using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {

            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */


            List<Course> courseList = new List<Course>() {
                new Course() { CourseId = 48579, Name = "American History through Shadow Puppetry" ,
                    Students = new List<Student> {
                        new Student() { StudentId = 7458, Name = "Steve the Wizard King" },
                        new Student() { StudentId = 7489, Name = "Abraham Lincoln" } } },
                new Course() { CourseId = 48599, Name = "Math for Dogs",
                    Students = new List<Student> {
                        new Student() { StudentId = 8034, Name = "Alex Winter" } ,
                        new Student() { StudentId = 7434, Name = "Hannibal Hamlin" } } },
                new Course() { CourseId = 48582, Name = "Advanced Egg Preparation" ,
                    Students = new List<Student> {
                        new Student() { StudentId = 7458, Name = "Steve the Wizard King" } ,
                        new Student() { StudentId = 5499, Name = "Totes MacLuggage" } } },
                new Course() { CourseId = 48676, Name = "The Economic Impact of Syzygy Events in Feudal Japan" ,
                    Students = new List<Student> {
                        new Student() { StudentId = 2124, Name = "William Hammer" } ,
                        new Student() { StudentId = 1388, Name = "Norville Barnes" } } }
            };

            string result = "";

            foreach (Course course in courseList)
            {
                result += "<h3>" + course.CourseId + " " + course.Name + "</h3>" + "Enrolled students:<br />";
                foreach ( Student student in course.Students)
                {
                    result += student.StudentId + " " + student.Name + "<br />";
                }
            }

            resultLabel.Text = result;




        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */

            Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>() {
                {8574, new Student { StudentId = 8574, Name = "Stanley Spadowski", Courses = new List<Course> {
                    new Course { CourseId = 73567, Name = "Overview of POGs" },
                    new Course { CourseId = 73596, Name = "The Philosophy of \'My Little Pony\'" } } } },
                {8575, new Student { StudentId = 8575, Name = "Biff Tannen", Courses = new List<Course> {
                    new Course { CourseId = 73442, Name = "Salt: How to Make it and What to Do with It" },
                    new Course { CourseId = 73289, Name = "Proper Hairdryer Maintenance" } } } },
                {8576, new Student { StudentId = 8576, Name = "Orson Welles", Courses = new List<Course> {
                    new Course { CourseId = 73621, Name = "The Etymology of Entomology" },
                    new Course { CourseId = 73928, Name = "Modern Dance for Robots" } } } }
            };

            string result = "";

            foreach ( KeyValuePair<int, Student> entry in studentDictionary )
            {
                result += "<h3>" + entry.Key + " " + entry.Value.Name + "</h3>" + "Enrolled in:<br />";
                foreach (Course course in entry.Value.Courses)
                {
                    result += course.CourseId + " " + course.Name + "<br />";
                }
            }

            resultLabel.Text = result;
        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>() {
                {8574, new Student { StudentId = 8574, Name = "Stanley Spadowski", Courses = new List<Course> {
                    new Course { CourseId = 73567, Name = "Overview of POGs" },
                    new Course { CourseId = 73596, Name = "The Philosophy of \'My Little Pony\'" } } } },
                {8575, new Student { StudentId = 8575, Name = "Biff Tannen", Courses = new List<Course> {
                    new Course { CourseId = 73442, Name = "Salt: How to Make it and What to Do with It" },
                    new Course { CourseId = 73289, Name = "Proper Hairdryer Maintenance" } } } },
                {8576, new Student { StudentId = 8576, Name = "Orson Welles", Courses = new List<Course> {
                    new Course { CourseId = 73621, Name = "The Etymology of Entomology" },
                    new Course { CourseId = 73928, Name = "Modern Dance for Robots" } } } }
            };

            Random random = new Random();
            string result = "";

            foreach (KeyValuePair<int, Student> entry in studentDictionary)
            {
                result += "<h3> " + entry.Value.Name + "</h3>" + "Enrolled in:<br />";
                foreach (Course course in entry.Value.Courses)
                {
                    entry.Value.StudentGrades = new Grades { course = course, grade = random.Next(0, 100) };
                    result += entry.Value.StudentGrades.course.Name + " - Current Grade: "+ entry.Value.StudentGrades.grade + "%<br />";
                };

                resultLabel.Text = result;

            }

        }
    }
}