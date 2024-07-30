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

        private string CourseID;
        private long TeacherID;
        private string CourseName;
        private string? Holding_status;

        public string آی_دی_کلاس { get { return CourseID; } set { CourseID = value; } }
        public long کد_ملی_استاد { get { return TeacherID; } set { TeacherID = value; } }
        public string نام_کلاس { get { return CourseName; } set { CourseName = value; } }
        public string? وضعیت_برگذاری { get { return Holding_status; } set
            {

            if(value == "True")
                {
                    Holding_status = "برگزار شده";
                }
            else if(value == "False")
                {
                    Holding_status = "برگزار نشده";
                }
            
            } }



    }
}
