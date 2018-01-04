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
  class CheckingAccount : Account
  {
    private decimal feePerTransaction;

    public CheckingAccount(decimal accountBalance, decimal transactionFee)
      : base(accountBalance)
    {

      feePerTransaction = transactionFee;
    }

    public decimal GetBalance()
    {
      return this.Balance;
    }

    public override decimal Credit(decimal addedAmount)
    {
      decimal balanceAfterCreditAmount = 0;
      if(addedAmount > 0)
      {
        balanceAfterCreditAmount = (this.bankBalance + addedAmount) - feePerTransaction;
      }else{
        throw new Exception("Transaction is insuccessfully!");
      }
      return balanceAfterCreditAmount;
    }

    public Boolean defineDebit(decimal withdrawalAmount)
    {
      if (withdrawalAmount <= (this.bankBalance + feePerTransaction))
      {
        return true;                                 
      }
      else
      {
        return false;
      }
    }

    public override decimal Debit(decimal withdrawalAmount)
    {
      if (defineDebit(withdrawalAmount) == true)
      {
        return base.Balance - withdrawalAmount - feePerTransaction;
      }
      else
      {
        throw new Exception("  Debit amount exceeded account balance.");
      }
    }

  }
}
