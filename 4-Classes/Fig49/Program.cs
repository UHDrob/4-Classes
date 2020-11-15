
// Fig. 4.8: Account.cs
// Account class with a constructor that initializes an Account's name.
using System;

namespace Fig49
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new Account("Jane Green");
            var account2 = new Account("John Blue");

            Console.WriteLine($"Account 1 Name: {account1.Name}");
            Console.WriteLine($"Account 2 Name: {account2.Name}");
        }
    }
}
