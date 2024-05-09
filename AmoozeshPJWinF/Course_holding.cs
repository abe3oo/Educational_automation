using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmoozeshPJWinF
{
    internal class Course_holding
    {
        public Course_holding()
        {

        }

        private string CourseID;
        private DateTime DateOfsection;
        private bool Holding_state;
        private long TeacherID;
        private DateTime? Date_of_remedical;

        public string courseid { get { return CourseID; } set { CourseID = value; } }
        public DateTime dateOfsection { get { return DateOfsection; } set { DateOfsection = value; } }
        public bool holding_state { get { return Holding_state; } set { Holding_state = value; } }
        public long teacherid { get { return TeacherID; } set { TeacherID = value; } }
        public DateTime? date_of_remedical { get { return Date_of_remedical; } set { Date_of_remedical = value; } }
    }
}
