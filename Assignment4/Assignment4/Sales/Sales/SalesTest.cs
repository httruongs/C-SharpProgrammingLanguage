/*  Deitel, H. and Deitel, P. (2014).  Visual C# 2012, How to Program, 
	Fifth Edition.  Upper Saddle River, New Jersey: Pearson Education.
	Modifications by W. Bowers, 2016
	Additional modifications by H. Truong, 2016
*/
using System;

public class SalesTest
{
   public static void Main( string[] args )
   {
     TruongHeading.getHeading("Assignment 4");
     Sales application = new Sales();
     application.CalculateSales();
     TruongHeading.getClosing();
     Console.Read();
   } // end Main
} // end class SalesTest


/**************************************************************************
 * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *************************************************************************/
