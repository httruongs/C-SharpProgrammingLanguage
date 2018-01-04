/*	BowersHeading.cs  W. Bowers (c) 2016 All Rights Reserved.
 *  This application may be used with my permission provided:  1) this copyright
 *  notice remains in place and unaltered; 2) not one word of code or syntax may
 *  be altered without specific, written instructions and permission; 3) the next
 *  user adds their modification notice to the existing audit trail; and 4) 
 *  permission to use automatically ends at the completion of this course.
 *  Additional modifications by H. Truong, 2016
*/
using System;
using System.Globalization;
using System.Text;

namespace Truong_3
{
  class HeartRates
  {
    private int curYear = DateTime.Now.Year;
    private int age;

    public HeartRates(String firstN, String lastN, int birthY)
    {
      firstName = firstN;
      lastName = lastN;
      birthYear = birthY;
      age = curYear - birthY;
    }
    public String firstName
    {
      get;
      set;
    }
    public String lastName
    {
      get;
      set;
    }
    public int birthYear
    {
      get;
      set;
    }
    public int currentYear
    {
      get
      {
        return curYear = DateTime.Now.Year;
      }
    }
    public int ages
    {
      get
      {
        return age;
      }
    }
    public int maxHeartRates
    {
      get
      {
        return 220 - age;
      }
    }
    public int minTargetHeartRates
    {
      get
      {
        return Convert.ToInt32(0.5 * maxHeartRates);
      }
    }
    public int maxTargetHeartRates
    {
      get
      {
        return Convert.ToInt32(0.85 * maxHeartRates);
      }
    }
    public String printOff
    {
      get
      {
       /* StringBuilder sb = new StringBuilder();
        sb.Append(String.Format("{0,-30}{1,-10}\n","  First Name: ", this.firstName));
        sb.Append(String.Format("{2,-30}{3,-10}\n","  Last Name: ", this.lastName));
        sb.Append(String.Format("{4,-30}{5,-10}\n", "  Birth Year: ", birthYear));
        sb.Append(String.Format("{6,-30}{7,-10}\n", "  Age: ", ages));
        sb.Append(String.Format("{8,-30}{9,3}{10, 18}\n", "  Max Heart Rate: ", maxHeartRates, " beats per minute"));
        sb.Append(String.Format("{11,-30}{12,3}{13,18}\n", "  Min Target Heart Rate: ", minTargetHeartRates,
           " beats per minute"));
        sb.Append(String.Format("{14,-30}{15,3}{16,18}", "  Max Target Heart Rate: ", maxTargetHeartRates, " beats per minute"));
        String s = sb.ToString();
        return s;*/
        return String.Format("{0,-30}{1,-10}\n{2, -30}{3,-10}\n{4,-30}{5,-10}\n{6,-30}{7,-10}\n{8,-30}{9,3}{10, 18}\n{11,-30}{12,3}{13,18}\n{14,-30}{15,3}{16,18}",
           "  First Name: ", this.firstName, "  Last Name: ", lastName, "  Birth Year: ", birthYear, "  Age: ", ages,
           "  Max Heart Rate: ", maxHeartRates, " beats per minute", "  Min Target Heart Rate: ", minTargetHeartRates,
           " beats per minute", "  Max Target Heart Rate: ", maxTargetHeartRates, " beats per minute");
      }
    }
  }
}
