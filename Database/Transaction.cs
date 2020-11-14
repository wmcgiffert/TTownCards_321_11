using System;
namespace TTownCards_321_11.Database
{
    public class Transaction
    {
        public int ID {get; set;}
        public DateTime TransDate {get; set;}
        public int TransAmount {get; set;}
        public int CustID {get; set;}
    }
}