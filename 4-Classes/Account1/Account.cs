// Fig. 4.2: Account.cs
// A simple Account class that contains a private instance
// variable name and public methods to Set and Get name's value.

using System;
using System.Collections.Generic;
using System.Text;

namespace Account1
{
   class Account
   {
      private string _name; // instance variable

      // method that sets the account name in the object
      public void SetName(string accountName)
      {
         _name = accountName; // store the account name
      }

      // method that retrieves the account name from the object
      public string GetName()
      {
         return _name; // returns name's value to this method's caller
      }
   }
}
