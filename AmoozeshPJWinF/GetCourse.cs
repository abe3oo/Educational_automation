using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmoozeshPJWinF
{
    internal class GetCourse
    {
        public GetCourse()
        {

        }

        private long CourseID;
        private long TeacherID;
        private string CourseName;
        private bool? Holding_status;

        public long courseid { get { return CourseID; } set { CourseID = value; } }
        public long teacherid { get { return TeacherID; } set { TeacherID = value; } }
        public string coursename { get { return CourseName; } set { CourseName = value; } }
        public bool? holding_status {  get { return Holding_status; } set { Holding_status = value; } }



    }
}
