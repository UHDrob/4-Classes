// FIg 4.12: AccountTest.cs
// Reading and Writing monetary amounts with Account object

using System;

namespace AccountTest
{
   class AccountTest
   {
      static void Main(string[] args)
      {
         // create two Account objects
         Account account1 = new Account("Jane Green", 50.00m);
         Account account2 = new Account("John Blue", -7.53m);

         // display initial balance for each Account
         Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
         Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

         // prompt for then read input
         Console.Write("\nEnter deposit amount for account1: ");
         decimal depositAmount = decimal.Parse(Console.ReadLine());
         Console.WriteLine($"adding {depositAmount:C} to account1 balance\n");
         account1.Deposit(depositAmount);

         // display balances
         Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
         Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

         // prompt for then read input
         Console.Write("\nEnter deposit aount for account2: ");
         depositAmount = decimal.Parse(Console.ReadLine());
         Console.WriteLine($"adding {depositAmount:C} to account2 balance\n");
         account2.Deposit(depositAmount); // add the account2's balance

         // display balances
         Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
         Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

      }
   }
}
