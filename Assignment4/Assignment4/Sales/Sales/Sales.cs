/*  Deitel, H. and Deitel, P. (2014).  Visual C# 2012, How to Program, 
	Fifth Edition.  Upper Saddle River, New Jersey: Pearson Education.
	Modifications by W. Bowers, 2016
	Additional modifications by H. Truong, 2016
*/
using System;
using System.Text;

public class Sales
{
  private const double basePay = 250.00;

  private double baseCommission = 0.09; // also known as the baseCommission variable
  private double commissionRate2 = 0.0925;
  private double commissionRate3 = 0.0701;
  private double commissionRate4 = 0.095;
  private double commissionRate5 = 0.10;
  private double commissionRate6 = 0.083;
  private double commissionRate7 = 0.091234;
  private double productPrice1 = 239.99;
  private double productPrice2 = 129.75;
  private double productPrice3 = 99.95;
  private double productPrice4 = 350.89;
  private double productPrice5 = 100.00;
  private double productPrice6 = 1000.00;
  private double productPrice7 = 123.45;
  private double product1Commission = 0;
  private double product2Commission = 0;
  private double product3Commission = 0;
  private double product4Commission = 0;
  private double product5Commission = 0;
  private double product6Commission = 0;
  private double product7Commission = 0;
  private double totalProductCommission = 0;
  private int product1Count = 0;
  private int product2Count = 0;
  private int product3Count = 0;
  private int product4Count = 0;
  private int product5Count = 0;
  private int product6Count = 0;
  private int product7Count = 0;
  private int totalProducts = 7;

  // calculate sales for individual products
  public void CalculateSales()
  {
    double grossSales = 0; // total gross sales
    double earnings; // earnings made from sales
    int product = 0; // the product number
    int numberSold; // number sold of a given product

    while (product < totalProducts)
    {
      ++product;

      // prompt for and read number of the product sold from user
      Console.Write("  Enter number sold of product # {0} -> ", product);
      numberSold = Convert.ToInt32(Console.ReadLine());

      // determine gross of each individual product and add to total
      if (product == 1)
      {
        product1Count = numberSold;
        grossSales += numberSold * productPrice1;
        product1Commission = (numberSold * productPrice1) * baseCommission;
      }
      else if (product == 2)
      {
        product2Count = numberSold;
        grossSales += numberSold * productPrice2;
        product2Commission = (numberSold * productPrice2) * commissionRate2;
      }
      else if (product == 3)
      {
        product3Count = numberSold;
        grossSales += numberSold * productPrice3;
        product3Commission = (numberSold * productPrice3) * commissionRate3;
      }
      else if (product == 4)
      {
        product4Count = numberSold;
        grossSales += numberSold * productPrice4;
        product4Commission = (numberSold * productPrice4) * commissionRate4;
      }
      else if (product == 5)
      {
        product5Count = numberSold;
        grossSales += numberSold * productPrice5;
        product5Commission = (numberSold * productPrice5) * commissionRate5;
      }
      else if (product == 6)
      {
        product6Count = numberSold;
        grossSales += numberSold * productPrice6;
        product6Commission = (numberSold * productPrice6) * commissionRate6;
      }
      else if (product == 7)
      {
        product7Count = numberSold;
        grossSales += numberSold * productPrice7;
        product7Commission = (numberSold * productPrice7) * commissionRate7;
      }
        totalProductCommission = product1Commission + product2Commission + product3Commission 
          + product4Commission + product5Commission + product6Commission + product7Commission;
    } // end while loop
    Console.WriteLine(String.Format("\n{0,29}{1,21}{2,27}", "Commission", "Price", "Comm"));
    Console.WriteLine(String.Format("  {0}{1,14}{2,9}{3,12}{4,15}{5,12}", "Sales Summary", 
      "Earnings", "Sold", "Each", "Extension", "Rates"));
    Console.WriteLine(String.Format("  {0}{1,14}{2,9}{3,12}{4,15}{5,12}", "-------------", "---------",
      "----", "-----", "---------", "-----"));
    Console.WriteLine(String.Format("  {0,-20}{1,-9:C}", "Base Pay", basePay));
    Console.WriteLine(String.Format("  Product 1            {0,6:F}  {1,6}{3,13:C}   {3,12:C}   {4,8:N}%", 
      product1Commission, product1Count, productPrice1, (product1Count * productPrice1), (baseCommission * 100)));
    Console.WriteLine(String.Format("  Product 2            {0,6:F}  {1,6}{3,13:N}   {3,12:N}   {4,8:N}%",
     product2Commission, product2Count, productPrice2, (product2Count * productPrice2), (commissionRate2 * 100)));
    Console.WriteLine(String.Format("  Product 3            {0,6:F}  {1,6}{3,13:N}   {3,12:N}   {4,8:N}%",
     product3Commission, product3Count, productPrice3, (product3Count * productPrice3), (commissionRate3 * 100)));
    Console.WriteLine(String.Format("  Product 4            {0,6:F}  {1,6}{3,13:N}   {3,12:N}   {4,8:N}%",
     product4Commission, product4Count, productPrice4, (product4Count * productPrice4), (commissionRate4 * 100)));
    Console.WriteLine(String.Format("  Product 5            {0,6:F}  {1,6}{3,13:N}   {3,12:N}   {4,8:N}%",
     product5Commission, product5Count, productPrice5, (product5Count * productPrice5), (commissionRate5 * 100)));
    Console.WriteLine(String.Format("  Product 6            {0,6:F}  {1,6}{3,13:N}   {3,12:N}   {4,8:N}%",
     product6Commission, product6Count, productPrice6, (product6Count * productPrice6), (commissionRate6 * 100)));
    Console.WriteLine(String.Format("  Product 7            {0,6:F}  {1,6}{3,13:N}   {3,12:N}   {4,8:N}%",
     product7Commission, product7Count, productPrice7, (product7Count * productPrice7), (commissionRate7 * 100)));
    earnings = Math.Abs(totalProductCommission + basePay); // calculate earnings
    Console.WriteLine("\n  Total Earnings {0,12:C}", earnings);
    Console.WriteLine("{0}", "                   ==========");
   // Console.ReadLine();
  } // end
  
} // end class Sales


/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *************************************************************************/
