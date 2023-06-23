using MySuperBank;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        var account = new BankAccount("Ming", 1000);
        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");


        account.MakeWithdrawal(120, DateTime.Now, "Hammock");
        account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");

        Console.WriteLine(account.GetAccountHistory());



    }
}