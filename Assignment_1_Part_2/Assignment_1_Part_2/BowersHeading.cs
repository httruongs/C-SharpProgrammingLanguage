/*	BowersHeading.cs  W. Bowers (c) 2016 All Rights Reserved.
 *  This application may be used with my permission provided:  1) this copyright
 *  notice remains in place and unaltered; 2) not one word of code or syntax may
 *  be altered without specific, written instructions and permission; 3) the next
 *  user adds their modification notice to the existing audit trail; and 4) 
 *  permission to use automatically ends at the completion of this course.
 *  Additional modifications by H. Truong, 2016
*/

using System;

public class BowersHeading
{
    private static string firstName = "Huong";
    private static string lastName = "Truong";
    static DateTime now = DateTime.Now;

  /*  public static void Main(string[] args)
    {
        getHeading("C-Sharp Programming 1");
        Console.WriteLine("  Personal Heading Class Self-Test");
        Console.WriteLine("\n  Testing the modified version of the " + getName()
                             + " personal heading class.");
        Console.WriteLine("  This demonstrates two styles for presenting the date, a formatted"
                             + " time\n  and utilization of a variety of interactive method calls.");
        getClosing();
    }   // end Main */

    public static String getName()
    {
        return getFirstName() + " " + getLastName();
    }   // end getName() 

    public static void getHeading(String assign)
    {
        Console.WriteLine("\n\n  " + getName() + "\n  " + assign);
        getDate();
    }   // end getHeading() 

    public static void getClosing()
    {   // Halt processing for viewing
        Console.WriteLine("\n  Program ended {0:dddd, MMMM d, yyyy} at {1:h:m tt}", now, now);
        Console.Write("  Press the Enter key to continue.\n\n");
        Console.ReadLine();
    }   // end getClosing() 

    public static void getDate()
    {
        Console.WriteLine("  {0:MMMM d, yyyy}\n", now);
    }   // end getDate() method

    public static string getFirstName()
    {
        return firstName;
    }   // end getFirstName() 

    public static string getLastName()
    {
        return lastName;
    }   // end getLastName() 

}   // end BowersHeading class 
