using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace Amozesh
{
    internal class Enrollment
    {
        public Enrollment()
        {

        }
        private string CourseID;
        private long StudentID;
        private string WhatsappGP;
        private DateTime DateOfEnrollment;

        public string courseid { get { return CourseID; } set { CourseID = value; } }
        public DateTime dateofenrollment { get { return DateOfEnrollment; } set { DateOfEnrollment = value; } }
        public long studentid { get { return StudentID; } set { StudentID = value; } }
        public string whatsappgp { get { return WhatsappGP; } set { WhatsappGP = value; } }

    }

}