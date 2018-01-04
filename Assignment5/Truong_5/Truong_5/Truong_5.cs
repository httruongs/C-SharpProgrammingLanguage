/*	BowersHeading.cs  W. Bowers (c) 2016 All Rights Reserved.
 *  This application may be used with my permission provided:  1) this copyright
 *  notice remains in place and unaltered; 2) not one word of code or syntax may
 *  be altered without specific, written instructions and permission; 3) the next
 *  user adds their modification notice to the existing audit trail; and 4) 
 *  permission to use automatically ends at the completion of this course.
 *  Additional modifications by H. Truong, 2016
*/
using System;
using System.Text;
using System.Collections;

namespace Truong_5
{
  class Truong_5
  {

    //static string Menu(string errorMessage)
    
    static string Menu()
    {
      var text = new StringBuilder("");
      text.Append("  Menu:\n");
      //if (errorMessage.Length > 0) {
      // text.Append(errorMessage);
      //}
      text.Append("  ----------------------------------------\n");
      text.Append("  1). Input my information\n");
      text.Append("  2). Display my BMI\n");
      text.Append("  3). Exit\n");
      return text.ToString();
    }

    static void Main(string[] args)
    {
      bool alreadyInputInfo = false;
      int height = 0;
      double weight = 0;
      Boolean canExit = false;

        //bool canExit = false;
        //while(canExit == false) {
        //   if(userInput == "3")  canExit = true;
        // }
      //while (true)
      while(!canExit) 
      {
        Console.Clear();
        TruongHeading.getHeading("Assignment 5");
       // string errors = "";
        string menu = Menu();
        Console.WriteLine(menu);
        Console.Write("  Choice: ");
        string input = Console.ReadLine();
        int inpValue;
        Console.Clear();
        //errors += "Error message";
        bool valid = Int32.TryParse(input, out inpValue);
        if (valid)
        {
          // exit application
          if (inpValue == 3)
          {
            Console.Clear();
            TruongHeading.getHeading("Assignment 5");
            Console.WriteLine("  You have exited the program!");
            TruongHeading.getClosing();
            System.Environment.Exit(1);
          }

          if (inpValue == 1)
          {
            Console.Clear();
            Console.WriteLine("  What is your height in inches: ");
            Console.SetCursorPosition(33, 0);
            bool validInput = false;
            String inputHeight = Console.ReadLine();
            //height = Int32.Parse(inputHeight);
            while(!validInput)
            {
              if(Int32.TryParse(inputHeight, out height))
              {
                if (height < 0)
                {
                  Console.Clear();
                  TruongHeading.getHeading("Assignment 5");
                  Console.WriteLine("  -------------------------------------");
                  Console.WriteLine("  Error(s):\n    - Error, you must enter a number greater than zero for height!");
                  Console.WriteLine("  -------------------------------------");
                  Console.WriteLine("  Please input your height in inches:");
                  String input3 = Console.ReadLine();
                  height = Convert.ToInt32(input3);
                }
                else
                {
                  alreadyInputInfo = true;
                  validInput = true;
                }
              }else{
                Console.Clear();
                TruongHeading.getHeading("Assignment 5");
                Console.WriteLine("  -------------------------------------");
                Console.WriteLine("  Error(s):\n    - Error, enter a number only for height!");
                Console.WriteLine("  -------------------------------------");
               // DisplayMenu(err);   //""  //"Error: Enter a number"
                Console.WriteLine("  Please input your height in inches:");
                String input4 = Console.ReadLine();
                bool inWord = false;
                while (!inWord)
                {
                  if (Int32.TryParse(input4, out height))
                  {
                    if (height < 0)
                    {
                      
                      Console.Clear();
                      TruongHeading.getHeading("Assignment 5");
                      Console.WriteLine("  -------------------------------------");
                      Console.WriteLine("  Error(s):\n    - Error, you must enter a number greater than zero for height!");
                      Console.WriteLine("  -------------------------------------");
                      Console.WriteLine("  Please input your height in inches:");
                      String input3 = Console.ReadLine();
                      height = Convert.ToInt32(input3);
                    }
                    else
                    {
                      alreadyInputInfo = true;
                      inWord = true;
                    }
                  }
                  else
                  {
                    Console.Clear();
                    TruongHeading.getHeading("Assignment 5");
                    Console.WriteLine("  -------------------------------------");
                    Console.WriteLine("  Error(s):\n    - Error, enter a number only for height!");
                    Console.WriteLine("  -------------------------------------");
                    Console.WriteLine("  Please input your height in inches:");
                    input4 = Console.ReadLine();
                    //break;
                  }
                }
              }
           
             Console.Clear();
             Console.WriteLine("  What is your weight in pounds: ");
             Console.SetCursorPosition(33, 0);
             String inputWeight = Console.ReadLine();
             //  weight = Convert.ToDouble(inputWeight);
             if (Double.TryParse(inputWeight, out weight))
             {
               if (weight < 0)
               {
                 Console.Clear();
                 TruongHeading.getHeading("Assignment 5");
                 Console.WriteLine("  -------------------------------------");
                 Console.WriteLine("  Error(s):\n    - Error, you must enter a number greater than zero for weight!");
                 Console.WriteLine("  -------------------------------------");
                 Console.WriteLine("  Please input your weight in pounds:");
                 String input5 = Console.ReadLine();
               }
               else
               {
                 alreadyInputInfo = true;
                 validInput = true;
               }

             }
             else
             {
               Console.Clear();
               TruongHeading.getHeading("Assignment 5");
               Console.WriteLine("  -------------------------------------");
               Console.WriteLine("  Error(s):\n    - Error, enter a number only for weight!");
               Console.WriteLine("  -------------------------------------");
               Console.WriteLine("  Please input your weight in pounds:");
               String input6 = Console.ReadLine();
               bool inWord1 = false;
               while (!inWord1)
               {
                 if (Double.TryParse(input6, out weight))
                 {
                   if (height < 0)
                   {

                     Console.Clear();
                     TruongHeading.getHeading("Assignment 5");
                     Console.WriteLine("  -------------------------------------");
                     Console.WriteLine("  Error(s):\n    - Error, you must enter a number greater than zero for height!");
                     Console.WriteLine("  -------------------------------------");
                     Console.WriteLine("  Please input your height in inches:");
                     String input3 = Console.ReadLine();
                     height = Convert.ToInt32(input3);
                   }
                   else
                   {
                     alreadyInputInfo = true;
                     inWord1 = true;
                   }
                 }
                 else
                 {
                   Console.Clear();
                   TruongHeading.getHeading("Assignment 5");
                   Console.WriteLine("  -------------------------------------");
                   Console.WriteLine("  Error(s):\n    - Error, enter a number only for height!");
                   Console.WriteLine("  -------------------------------------");
                   Console.WriteLine("  Please input your height in inches:");
                   input6 = Console.ReadLine();
                  
                 }
               }

             }
            }
           }
        // option 2
          if (inpValue == 2)
          {
            if (alreadyInputInfo == false)
            {
              Console.Clear();
              TruongHeading.getHeading("Assignment 5");
              Console.WriteLine("  Menu:");
              Console.WriteLine("  ----------------------------------------");
              Console.WriteLine("  Error(s):\n    - You must input user info (choice 1) before");
              Console.WriteLine("      you can calculate BMI");
              Console.WriteLine("  ----------------------------------------");
              Console.WriteLine("  1). Input my information");
              Console.WriteLine("  2). Display my BMI");
              Console.WriteLine("  3). Exit\n");
              Console.WriteLine("  Choice: ");
              Console.SetCursorPosition(10, 16);
              string input2 = Console.ReadLine();
              bool intInput2 = Int32.TryParse(input2, out inpValue);
            }
            else if (alreadyInputInfo == true)
            {
              Console.Clear();
              TruongHeading.getHeading("Assignment 5");
              Console.WriteLine("  BMI VALUES");
              Console.WriteLine("  -------------------------------------------");
              Console.WriteLine("  {0,-20}{1}", "Underweight:", "less than 18.5");
              Console.WriteLine("  {0,-20}{1}", "Normal:", "between 18.5 and 24.9");
              Console.WriteLine("  {0,-20}{1}", "Overweight", "between 25 and 29.9");
              Console.WriteLine("  {0,-20}{1}", "Obese", "30 and greater");
              Console.WriteLine("  -------------------------------------------");
              Person person = new Person(height, weight);
              Console.WriteLine(person.BMIName);
              TruongHeading.getClosing();
            }
          }
        }//end valid
        else
        {
          Console.Clear();
          TruongHeading.getHeading("Assignment 5");
          Console.WriteLine("  Menu:");
          Console.WriteLine("  ----------------------------------------");
          Console.WriteLine("  Error(s):\n");
          Console.WriteLine("     - Input a number only (1-3)");
          Console.WriteLine("  ----------------------------------------");
          Console.WriteLine("  1). Input my information");
          Console.WriteLine("  2). Display my BMI");
          Console.WriteLine("  3). Exit\n");
          Console.WriteLine("  Choice: ");
          string input7 = Console.ReadLine();
          bool intInput7 = Int32.TryParse(input7, out inpValue);
        }
      }//end while
    }//end main
  }//end class
}// end namespace
  

