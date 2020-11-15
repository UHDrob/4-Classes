using System;

namespace Fig413
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new Account("Jane Green", 50.00m); 
            var account2 = new Account("John Blue", -7.53m);

            //Display balances
            Console.WriteLine($"Account 1 Balance: {account1.Balance:C}");
            Console.WriteLine($"Account 2 Balance: {account2.Balance:C}");

            Console.Write("\n Enter deposit amount for account 1: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount} to account 1 balance\n");
            account1.Deposit(depositAmount);

            //Display balances
            Console.WriteLine($"Account 1 Balance: {account1.Balance}");
            Console.WriteLine($"Account 2 Balance: {account2.Balance}");

            Console.Write("\n Enter deposit amount for account 2: ");
            depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount} to account 2 balance\n");
            account2.Deposit(depositAmount);

            //Display balances
            Console.WriteLine($"Account 1 Balance: {account1.Balance}");
            Console.WriteLine($"Account 2 Balance: {account2.Balance}");
        }
    }
}
