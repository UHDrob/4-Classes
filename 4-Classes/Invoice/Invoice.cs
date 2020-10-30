// Exercise 4.12 Solution: Invoice.cs
// Invoice class.

using System;
using System.Collections.Generic;
using System.Text;

namespace Invoice
{
   public class Invoice
   {
      // auto-implemented property implicitly creates an 
      // instance variable for the part number
      public string PartNumber { get; set; }

      // auto-implemented property implicitly creates an 
      // instance variable for the part description
      public string PartDescription { get; set; }

      private int quantity;
      private decimal pricePerItem;

      // four-parameter constructor
      public Invoice(string part, string description, int count,
         decimal price)
      {
         // initialize automatic properties and instance variables
         PartNumber = part;
         PartDescription = description;
         Quantity = count;
         PricePerItem = price;
      } // end four-parameter Invoice constructor

      // property to get and set the quantity
      public int Quantity
      {
         get
         {
            return quantity;
         } // end get
         set
         {
            if (value >= 0) // determine whether count is positive
               quantity = value; // valid count assigned to quantity
         } // end set
      } // end property Quantity

      // property to get and set the price per item
      public decimal PricePerItem
      {
         get
         {
            return pricePerItem;
         } // end get
         set
         {
            if (value >= 0) // determine whether price is nonnegative
               pricePerItem = value; // valid price assigned to pricePerItem
         } // end set
      } // end property PricePerItem

      // calculates and returns the invoice amount
      public decimal GetInvoiceAmount()
      {
         return Quantity * PricePerItem; // calculate total cost
      } // end method GetInvoiceAmount
   } // end class Invoice
}
