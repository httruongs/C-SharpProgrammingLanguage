/*	BowersHeading.cs  W. Bowers (c) 2016 All Rights Reserved.
 *  This application may be used with my permission provided:  1) this copyright
 *  notice remains in place and unaltered; 2) not one word of code or syntax may
 *  be altered without specific, written instructions and permission; 3) the next
 *  user adds their modification notice to the existing audit trail; and 4) 
 *  permission to use automatically ends at the completion of this course.
 *  Additional modifications by H. Truong, 2016
*/
using System;

namespace Truong_10
{
  public class Account
  {
    private decimal accountBalance;

    //Constructor
    public Account(decimal balance)
    {
      bankBalance = balance;
    }

    public decimal bankBalance
    {
      get
      {
        return accountBalance;
      }
      set
      {
        if (value >= 0.0M)
        {
          accountBalance = value;
        }
        else
        {
          throw new ArgumentOutOfRangeException("Please try again with a number greater than or equal to 0");
        }
      }//end set
    }//end property bankBalance

    protected decimal Balance
    {
      get
      {
        return accountBalance;
      }
    }

    // deposit
    public virtual decimal Credit(decimal amount)
    {
      if (amount > 0)
      {
        return accountBalance += amount;
      }
      else
      {
        throw new Exception("The transaction is unsuccessfully!");
      }
    }

    // withdrawal
    public virtual decimal Debit(decimal amount)
    {
      if (amount <= accountBalance)
      {
        return accountBalance -= amount;
      }
      else
      {
         throw new Exception("Debit amount exceeded account balance.");
      }
    }
  }
}
