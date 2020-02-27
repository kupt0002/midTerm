using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermSolution
{
    public class Course
    {
        public static List<Course> AvailableCourses
        {
            get
            {
                List<Course> courses = new List<Course>();
                Course course = new Course("Object Oriented Programming in C#", 6);
                courses.Add(course);

                course = new Course("Web Programming in PHP", 4);
                courses.Add(course);

                course = new Course("Java Programming in 21 Days", 4);
                courses.Add(course);

                course = new Course("Advanced Database Topics", 6);
                courses.Add(course);

                course = new Course("PHP Web Application Development", 8);
                courses.Add(course);

                course = new Course("Professional ASP.NET MVC Programming", 2);
                courses.Add(course);

                course = new Course("Professional ASP.NET Core MVC", 4);
                courses.Add(course);

                course = new Course("JavaScript Web Programming", 5);
                courses.Add(course);

                course = new Course("Professional JQuery", 2);
                courses.Add(course);

                return courses;
            }
        }
        public string Title { get;  }
        public int WeeklyHours { get; }

        private Course(string title, int hours)
        {
            Title = title;
            WeeklyHours = hours;
        }
    }
}
