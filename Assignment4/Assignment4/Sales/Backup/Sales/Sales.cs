// Exercise 5.19 Solution: Sales.cs
// Application calculates commissions based on sales.
using System;

public class Sales
{
   // calculate sales for individual products
   public void CalculateSales()
   {
      decimal grossSales = 0; // total gross sales
      decimal earnings; // earnings made from sales
      int product = 0; // the product number
      int numberSold; // number sold of a given product

      while ( product < 4 )
      {
         ++product;

         // prompt for and read number of the product sold from user
         Console.Write( "Enter number sold of product #{0}: ",
            product );
         numberSold = Convert.ToInt32( Console.ReadLine() );

         // determine gross of each individual product and add to total
         if ( product == 1 )
            grossSales += numberSold * 239.99M;
         else if ( product == 2 )
            grossSales += numberSold * 129.75M;
         else if ( product == 3 )
            grossSales += numberSold * 99.95M;
         else if ( product == 4 )
            grossSales += numberSold * 350.89M;
      } // end while loop

      earnings = 0.09M * grossSales + 200; // calculate earnings
      Console.WriteLine( "Earnings this week: {0:C}", earnings );
      
   } // end Main
} // end class Sales


/**************************************************************************
 * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
