using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmoozeshPJWinF
{
    internal class student : users
    {
        public student()
        {

        }


        
        private int Education;
        private bool MaritalStatus;
        private string Job;
        private string City;
        private bool Classtype;


        
        public int education { get { return Education; } set { Education = value; } }
        public bool maritalstatus { get { return MaritalStatus; } set { MaritalStatus = value; } }
        public string job { get { return Job; } set { Job = value; } }
        public string city { get { return City; } set { City = value; } }
        public bool classtype { get { return Classtype; } set { Classtype = value; } }
    }
}
