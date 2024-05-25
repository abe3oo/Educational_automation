using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmoozeshPJWinF
{
    internal class showcourse
    {
        public showcourse()
        {

        }
        
        private string CourseID;
        private long TeacherID;
        private string CourseName;
        private string TeacherName;
        private string Term;
        private DateTime Start_Date;
        private long Cost;
        private string Clock;

        public string courseid { get { return CourseID; } set { CourseID = value; } }
        public long teacherid { get { return TeacherID; } set { TeacherID = value; } }
        public string coursename { get { return CourseName; } set { CourseName = value; } }
        public string teachername { get {return TeacherName; } set {TeacherName = value; } }
        public string term
        {
            get { return Term; }
            set
            {
                if (value == "1")
                {
                    Term = "بهار";
                }
                else if (value == "2")
                {
                    Term = "تابستان";
                }
                else if (value == "3")
                {
                    Term = "پاییز";
                }
                else if(value == "4")
                {
                    Term = "زمستان";
                }
                else
                {
                    Term = value;
                }
            }
        }
        public DateTime start_date { get { return Start_Date; } set { Start_Date = value; } }
        public long cost { get { return Cost; } set { Cost = value; } }
        public string clock { get { return Clock; } set { Clock = value; } }


    }
}
