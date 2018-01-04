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


namespace Truong_10
{
  class Truong_10
  {
    static void Main(string[] args)
    {

      decimal balance = 2000;
      decimal yearInterest = 0.04M;
      decimal feeTransaction = 10.00M;

      TruongHeading.getHeading("Assignment 10");
      Account account = new Account(balance);
      Console.WriteLine("  The balance is {0}", balance);

      account.Credit(200);
      Console.WriteLine("  The balance credit $200 is {0}", account.bankBalance);
      
      try
      {
        account.Debit(300);
        Console.WriteLine("  The balance debit $300 is {0}", account.bankBalance);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
      
      SavingsAccount savingAccount = new SavingsAccount(balance, yearInterest);
      Console.WriteLine("\n  The saving account: ");
      Console.WriteLine("  The new balance is {0} ", savingAccount.GetBalance());      

      Console.WriteLine("  The interest amount is {0}", savingAccount.CalculateInterest());
      
      savingAccount.Credit(savingAccount.CalculateInterest());
      Console.WriteLine("  The new balance is {0} ", savingAccount.GetBalance());


      CheckingAccount checkingAccount = new CheckingAccount(balance, feeTransaction);
      Console.WriteLine("\n  The checking account: ");
      Console.WriteLine("  The checking balance account is {0}", checkingAccount.GetBalance());
      try
      {
        checkingAccount.Debit(500M);
        Console.WriteLine("  The checking balance account debit $500 is {0}", checkingAccount.Debit(500));
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      
      try
      {
        checkingAccount.Debit(2500M);
        Console.WriteLine("  The checking balance debit $2500 is {0}", checkingAccount.Debit(2500));
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      TruongHeading.getClosing();
      Console.ReadLine();
    }
  }
}
