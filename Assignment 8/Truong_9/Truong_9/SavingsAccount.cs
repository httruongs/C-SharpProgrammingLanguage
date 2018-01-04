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
  class SavingsAccount
  {
    private static double annualInterestRate = 0.0;
    private double savingsBalance;
    
    //Constructor
    public SavingsAccount(double balance)
    {
      savingsBalance = balance;
    }
    
    public static void ModifyInterestRate(double yearlyInterestRate)
    {
      annualInterestRate = yearlyInterestRate;
    }
    public double CalculateMonthlyInterest()
    {
      return (savingsBalance * annualInterestRate) / 12;
    }


  }
}

