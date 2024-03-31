using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace Amozesh
{
    internal class Course
    {
        public Course()
        {

        }
        private long CourseID;
        private DateTime DateOfStart;
        private long Cost;
        private long TeacherID;
        private string CourseName;

        public long courseid { get { return CourseID; } set { CourseID = value; } }
        public DateTime dateofstart { get { return DateOfStart; } set { DateOfStart = value; } }
        public long cost { get { return Cost; } set { Cost = value; } }
        public long teacherid { get { return TeacherID; } set { TeacherID = value; } }
        public string  coursename { get { return CourseName; } set { CourseName = value; } }
        

    }
}