/*	BowersHeading.cs  W. Bowers (c) 2016 All Rights Reserved.
 *  This application may be used with my permission provided:  1) this copyright
 *  notice remains in place and unaltered; 2) not one word of code or syntax may
 *  be altered without specific, written instructions and permission; 3) the next
 *  user adds their modification notice to the existing audit trail; and 4) 
 *  permission to use automatically ends at the completion of this course.
 *  Additional modifications by H. Truong, 2016
*/
using System;


namespace Truong_9
{
  class Truong_9
  {
    static void Main(string[] args)
    {
      TruongHeading.getHeading("Assignment 9");

      double balance1 = 2000.00, balance2 = 3000.00;
     
      SavingsAccount saver1 = new SavingsAccount(balance1);
      SavingsAccount saver2 = new SavingsAccount(balance2);

      SavingsAccount.ModifyInterestRate(0.04);

      double monthlyInterestMoney1 = saver1.CalculateMonthlyInterest();
      double monthlyInterestMoney2 = saver2.CalculateMonthlyInterest();
      Console.WriteLine("  Monthly new balance of customer 1 at 4% is: {0:C}", 
        balance1 + monthlyInterestMoney1);
      Console.WriteLine("  Monthly new balance of customer 2 at 4% is: {0:C}",
        balance2 + monthlyInterestMoney2);
      Console.WriteLine();

      SavingsAccount.ModifyInterestRate(0.05);

      double monthlyInterestMoney3 = saver1.CalculateMonthlyInterest();
      double monthlyInterestMoney4 = saver2.CalculateMonthlyInterest();
      Console.WriteLine("  Monthly new balance of customer 1 at the interest rate 5% is: {0:C}",
        balance1 + monthlyInterestMoney3);
      Console.WriteLine("  Monthly new balance of customer 2 at the interest rate 5% is: {0:C}",
        balance2 + monthlyInterestMoney4);
      TruongHeading.getClosing();
      Console.ReadLine();
    }
  }
}
