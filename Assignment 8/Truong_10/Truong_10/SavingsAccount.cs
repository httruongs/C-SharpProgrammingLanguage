/*	BowersHeading.cs  W. Bowers (c) 2016 All Rights Reserved.
 *  This application may be used with my permission provided:  1) this copyright
 *  notice remains in place and unaltered; 2) not one word of code or syntax may
 *  be altered without specific, written instructions and permission; 3) the next
 *  user adds their modification notice to the existing audit trail; and 4) 
 *  permission to use automatically ends at the completion of this course.
 *  Additional modifications by H. Truong, 2016
*/
using System;
using Truong_10;

namespace Truong_10
{
  public class SavingsAccount : Account
  {
    private decimal interestRate;

    //Constructor
    public SavingsAccount(decimal balance, decimal yearInterest)
      : base(balance)
    {
      interestRate = yearInterest;
    }

    public decimal GetBalance()
    {
      return base.Balance;
    }

    public decimal CalculateInterest()
    {
      decimal interestAmount = 0.0M;
      interestAmount = this.bankBalance * interestRate;
      return interestAmount;
    }

  }
}
