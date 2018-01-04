/*	BowersHeading.cs  W. Bowers (c) 2016 All Rights Reserved.
 *  This application may be used with my permission provided:  1) this copyright
 *  notice remains in place and unaltered; 2) not one word of code or syntax may
 *  be altered without specific, written instructions and permission; 3) the next
 *  user adds their modification notice to the existing audit trail; and 4) 
 *  permission to use automatically ends at the completion of this course.
 *  Additional modifications by H. Truong, 2016
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Truong_8
{
  class Truong
  {
    static void Main(string[] args)
    {
      Invoice[] myInvoice = new Invoice[8];
      Invoice invoice1 = new Invoice(83, "Electric sander", 7, 57.98M);
      Invoice invoice2 = new Invoice(24, "Power saw", 18, 99.99M);
      Invoice invoice3 = new Invoice(7, "Sledge hammer", 11, 21.50M);
      Invoice invoice4 = new Invoice(77, "Hammer", 76, 11.99M);
      Invoice invoice5 = new Invoice(39, "Lawn mower", 3, 79.50M);
      Invoice invoice6 = new Invoice(68, "Screwdriver", 106, 6.99M);
      Invoice invoice7 = new Invoice(56, "Jig saw", 21, 11.00M);
      Invoice invoice8 = new Invoice(3, "Wrench", 34, 7.50M);

      myInvoice[0] = invoice1;
      myInvoice[1] = invoice2;
      myInvoice[2] = invoice3;
      myInvoice[3] = invoice4;
      myInvoice[4] = invoice5;
      myInvoice[5] = invoice6;
      myInvoice[6] = invoice7;
      myInvoice[7] = invoice8;
      
      //sort the Invoice Objects by PartDescription
      var sortPartDescription = from item in myInvoice orderby item.PartDescription select item;
      TruongHeading.getHeading("Assignment 8");
      Console.WriteLine("  {0, -18}{1, -20}{2, -20}{3, -20}", "Part number", "Part description", 
        "Quantity", "Price");
      Console.WriteLine("  {0, -18}{1, -20}{2, -20}{3, -20}", "-----------", "----------------",
        "----------", "------");

      //item is element we name it, item of the what? is the part we need to do. Then select the element item. 
      
      foreach (Invoice invoiceItem in sortPartDescription) // sort it from the part holds sort.
        Console.WriteLine("  {0, -18}{1, -20}{2, -20}${3, -20}", invoiceItem.PartNumber, 
          invoiceItem.PartDescription, invoiceItem.Quantity, invoiceItem.Price);
   
      //sort the Invoice objects by Price
      var sortPrice = from sortList in myInvoice orderby sortList.Price select sortList;
      Console.WriteLine("  -----------------------------------------------------------------------\n");
      Console.WriteLine("  {0, -18}{1, -20}{2, -20}{3, -20}", "Part number", "Part description", 
        "Quantity", "Price");
      Console.WriteLine("  {0, -18}{1, -20}{2, -20}{3, -20}", "-----------", "----------------",
        "----------", "------");
      foreach (Invoice invoiceItem in sortPrice)
        Console.WriteLine("  {0, -18}{1, -20}{2, -20}${3, -20}", invoiceItem.PartNumber, 
          invoiceItem.PartDescription, invoiceItem.Quantity, invoiceItem.Price);
     
      var sortBoth = from element in myInvoice
                     orderby element.Quantity
                     select new { element.PartDescription, element.Quantity };

      Console.WriteLine("  -------------------------------------------------------------------------\n");
      Console.WriteLine("  {0, -18}{1, -20}", "Part description", "Quantity");
      Console.WriteLine("  {0, -18}{1, -20}", "----------------", "--------");         
      //var secondSort = from something in myInvoice orderby something.Quantity select sortBoth;
      foreach (var abc in sortBoth)
        Console.WriteLine("  {0, -18}{1, -20}", abc.PartDescription, abc.Quantity);
      //Select from each Invoice the PartDescription and the value of the 
      //Invoice.(InvoicceTotal). Order resutls by Invoice value.
      
      var sortInvoiceValue = from sortInvoice in myInvoice 
                             let InvoiceTotal = sortInvoice.Quantity * sortInvoice.Price
                             orderby InvoiceTotal
                             select new {sortInvoice.PartDescription, InvoiceTotal};

      Console.WriteLine("  -----------------------------------------------\n");
      Console.WriteLine("  {0, -18}{1, -30}", "Part description","Invoice Total");
      Console.WriteLine("  {0, -18}{1, -30}", "----------------", "-------------");
                 
      foreach (var sortInv in sortInvoiceValue)
        Console.WriteLine("  {0, -18} ${1, -20}", sortInv.PartDescription, sortInv.InvoiceTotal);

      
     //Using results of the LinQ query in Part d, select  the InvoiceTotals in the range $200 to $500
      var sortNumber = from sortNumberRange in sortInvoiceValue
                       where sortNumberRange.InvoiceTotal >= 200 && sortNumberRange.InvoiceTotal <= 500
                       select sortNumberRange;
      Console.WriteLine("  -----------------------------------------------\n");
      Console.WriteLine("  {0, -18}{1, -30}", "Part description", "Invoice Total");
      Console.WriteLine("  {0, -18}{1, -30}", "----------------", "-------------");
      foreach (var resultSortInvoice in sortNumber)
        Console.WriteLine("  {0, -18} ${1, -20}", resultSortInvoice.PartDescription, 
          resultSortInvoice.InvoiceTotal);
      TruongHeading.getClosing();
      Console.ReadLine();


      //var sortPart = blabla;
      //List<Inventory> = SortParts.ToList<Inventory>();
    }
   // public static object InvoiceTotal { get; set; }
  }
}
