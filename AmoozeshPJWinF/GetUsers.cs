using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmoozeshPJWinF
{
    internal class GetUsers
    {
        public GetUsers()
        {
            account_balance = 0;
        }
        private string? PersonalCode;
        private string? Firstname;
        private string? Lastname;
        private int? Age;
        private string? Fieled_of_study;
        private long? Number;
        private long? WhatsAppNumber;
        private byte[]? ProfilePicture;
        private long Account_balance;

        public string? personalcode { get { return PersonalCode; } set { PersonalCode = value; } }
        public string? firstname { get { return Firstname; } set { Firstname = value; } }
        public string? lastname { get { return Lastname; } set { Lastname = value; } }
        public int? age { get { return Age; } set { Age = value; } }
        public string? fieled_of_study { get { return Fieled_of_study; } set { Fieled_of_study = value; } }
        public long? number { get { return Number; } set { Number = value; } }

        public long? whatsappnumber { get { return WhatsAppNumber; } set { WhatsAppNumber = value; } }
        public byte[]? profilepicture { get { return ProfilePicture; } set { ProfilePicture = value; } }
        public long account_balance { get { return Account_balance; } set { Account_balance = value; } }
    }
}
