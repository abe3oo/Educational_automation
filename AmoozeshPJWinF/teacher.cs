using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmoozeshPJWinF
{
    internal class teacher : users
    {
        public teacher()
        {

        }



        private DateTime Date_of_entry;
        private int Degree_of_education;
        private int Presence_record;


        public DateTime date_of_entry { get { return Date_of_entry; } set { Date_of_entry = value; } }
        public int degree_of_education { get { return Degree_of_education; } set { Degree_of_education = value; } }
        public int presence_record { get { return Presence_record; } set { Presence_record = value; } }
    }
}
