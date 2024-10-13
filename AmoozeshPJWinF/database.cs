using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmoozeshPJWinF
{
    internal class database
    {
        public database()
        {

        }

        private string Host;
        private string Port;
        private string DatabaseName;
        private string User;
        private string Password;

        public string host { get { return Host; } set { Host = value; } }
        public string port { get { return Port; } set { Port = value; } }
        public string databaseName { get { return DatabaseName; } set { DatabaseName = value; } }
        public string user { get { return User; } set { User = value; } }
        public string password { get { return Password; } set { Password = value; } }
    }
}
