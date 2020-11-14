using System.Data;
using System.Runtime.InteropServices;
using System;
using System.Data.SQLite;
namespace TTownCards_321_11.Database
{
    public class InventorySeedData
    {
         string cs = @"...";
            using var con = new SQLiteConnection(cs);
            con.Open();
            using var cmd = new SQLiteCommand(con);

        //Drop table if it exists
            cmd.CommandText = "DROP TABLE IF EXISTS posts";
            cmd.ExecuteNonQuery();

        //Create inventory table
            cmd.CommandText = @"CREATE TABLE Inventory (ID INTEGER PRIMARY KEY, ProductName TEXT, AthleteName TEXT, SportsTeam TEXT, Year INTEGER, PSGrade TEXT, Status TEXT, ArrivalDate DATETIME, SoldDate DATETIME, TransactionId FOREIGN KEY, PurchasePrice INTEGER, Price INTEGER, ProductDescription TEXT, AthleteSport TEXT)";
            cmd.ExecuteNonQuery();

        //insert data
        cmd.CommandText = @"INSERT INTO Inventory(ID,ProductName, AthleteName, SportsTeam, Year, PSGrade, Status, ArrivalDate, SoldDate, TransactionId,PurchasePrice, Price, ProductDescription, AthleteSport) VALUES(@ProductName, @AthleteName, @SportsTeam, @Year, @PSGrade, @Status, @ArrivalDate, @SoldDate, @TransactionId, @PurchasePrice, @Price, @ProductDescription, @AthleteSport)";
        cmd.Prepare();
        cmd.ExecuteNonQuery();

    }
}