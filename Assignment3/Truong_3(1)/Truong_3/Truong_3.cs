/*	BowersHeading.cs  W. Bowers (c) 2016 All Rights Reserved.
 *  This application may be used with my permission provided:  1) this copyright
 *  notice remains in place and unaltered; 2) not one word of code or syntax may
 *  be altered without specific, written instructions and permission; 3) the next
 *  user adds their modification notice to the existing audit trail; and 4) 
 *  permission to use automatically ends at the completion of this course.
 *  Additional modifications by H. Truong, 2016
*/
using System;

namespace Truong_3
{
  class Truong_3
  {
    static void Main(string[] args)
    {
      TruongHeading.getHeading("Assignment 3");
      Console.WriteLine("  Please enter your first name.");
      Console.SetCursorPosition(2, 7);
      String input1 = Console.ReadLine();
      Console.WriteLine("  Please enter your last name.");
      Console.SetCursorPosition(2, 9);
      String input2 = Console.ReadLine();
      Console.WriteLine("  Please enter your birth year.");
      Console.SetCursorPosition(2, 11);
      int input3 = Convert.ToInt32(Console.ReadLine());
      Console.Clear();
      TruongHeading.getHeading("Assignment 3");
      Console.WriteLine("  ==================================================");
      Console.Write("  The following information was input:\n\n");
      HeartRates hrates = new HeartRates(input1, input2, input3);
      Console.WriteLine(hrates.printOff);
      TruongHeading.getClosing();
    }
  }
}
