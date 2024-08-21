using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace Amozesh
{
    internal class Payment
    {
        public Payment()
        {

        }
        private long UserID;
        private DateTime DateOfPayment;
        private int Term;
        private long Amount;
        private long TrackingCode;
        private bool TransactionStatus;
        private TimeSpan TrackingTime;
        private string Description;
        
        public long userid { get { return UserID; } set { UserID = value; } }
        public DateTime dateofpayment { get { return DateOfPayment; } set { DateOfPayment = value; } }
        public int term { get { return Term; } set { Term = value; } }
        public long amount { get { return Amount; } set { Amount = value; } }
        public long trackingcode { get { return TrackingCode; } set { TrackingCode = value; } }
        public TimeSpan tarckingtime { get { return TrackingTime; } set { TrackingTime = value; } }
        public bool transactionstatus { get { return TransactionStatus; } set { TransactionStatus = value; } }
        public string description { get { return Description; } set { Description = value; } }
        
    }
}