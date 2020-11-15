// Fig. 4.6: Account.cs
// Account class that replaces public methods SetName
// and GetName with a public Name property.

using System;
using System.Collections.Generic;
using System.Text;

namespace Account2
{
   class Account
   {
      private string _name; // instance variable

      // property to get and set the name instance variable               
      public string Name
      {
         get // returns the corresponding instance variable's value
         {
            return _name; // returns the value of name to the client code
         }
         set // assigns a new value to the corresponding instance variable
         {
            _name = value; // value is implicitly declared and initialized
         }
      }
   }
}
