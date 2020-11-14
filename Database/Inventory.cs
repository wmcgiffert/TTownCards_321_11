using System;
namespace TTownCards_321_11.Database
{
    public class Inventory
    {
        public int ID {get; set;}
        public string ProductName {get; set;}
        public string AthleteName {get; set;}
        public string SportsTeam {get; set;}
        public int Year {get; set;}
        public string PSGrade {get; set;}
        public string Status {get; set;}
        public DateTime ArrivalDate {get; set;}
        public DateTime SoldDate {get; set;}
        public int TransactionId {get; set;}
        public int PurchasePrice {get;set;}
        public int Price {get;set;}
        public string ProductDescription{get;set;}
        public string AthleteSport {get; set;}
    }
}