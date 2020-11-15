// Fig. 4.8: Account.cs
// Account class with a constructor that initializes an Account's name.

using System;
using System.Collections.Generic;
using System.Text;

namespace Account3
{
   class Account
   {
      public string Name { get; set; } // auto-implemented property

      // constructor sets the Name property to parameter accountName's value
      public Account(string accountName) // constructor name is class name 
      {
         Name = accountName;
      }


   }
}
