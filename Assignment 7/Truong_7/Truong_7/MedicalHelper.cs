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

namespace Truong_7
{
  public static class MedicalHelper
  {
    const string APP_NAME = "My Medical Helper";
    public static double BMI = 0.0;
    static Patient[] patients = new Patient[100];
    static int validPatientIdx = 0;
    static bool alreadyInput = false;

    public static double GetBMIValue(double weightPounds, double heightInches)
    {
      BMI = (weightPounds * 703) / (heightInches * heightInches);
      return BMI;
    }

    public static string GetBMIName(double weightPounds, double heightInches)
    {
      string retVal = "";
      if (BMI < 18.5)
        retVal = String.Format("  {0, -25}: {1:0.00}", "BMI is considered is:", "Underweight");
      else if (18.5 < BMI && BMI < 24.9)
        retVal = String.Format("  {0, -25}: {1:0.00}", "BMI is considered is:", "Normal");
      else if (25 < BMI && BMI < 29.9)
        retVal = String.Format("  {0, -25}: {1:0.00}", "BMI is considered is:", "Overweight");
      else if (BMI >= 30)
        retVal = String.Format("  {0, -25}: {1:0.00}", "BMI is considered is:", "Obese");
      return retVal;
    }

    public static int GetMaxinumHeartRate(int age)
    {
      return 220 - age;
    }

    public static int GetMaxTargetHeartRate(int age)
    {
      return Convert.ToInt32(0.85 * Convert.ToDouble(GetMaxinumHeartRate(age)));
    }

    public static int GetMinTargetHeartRate(int age)
    {
      return Convert.ToInt32(0.5 * Convert.ToDouble(GetMaxinumHeartRate(age)));
    }


    // Main method


    static void Main(string[] args)
    {
      displayMainMenu();

      Console.ReadLine();
    }

    static string Menu()
    {
      StringBuilder menu = new StringBuilder();
      menu.Append("  1). Create Patient\n");
      menu.Append("  2). List Patient\n");
      menu.Append("  3). Quit\n");
      menu.Append("  -------------------");
      return menu.ToString();
    }


    static int displayMainMenu()
    {
      int choice = 0;
      bool invalidChoice = false;
      string inputChoice = "";

      while (!invalidChoice) 
      {
        Console.Clear();
        TruongHeading.getHeading(APP_NAME);
        string menu = Menu();
        Console.WriteLine(menu);
        Console.Write("  Choice: ");
        inputChoice = Console.ReadLine();

        
        
        
        
        if (!int.TryParse(inputChoice, out choice))
        {
          Console.WriteLine("  Error!");
          Console.WriteLine("  - Enter a numeric value only!");
          Console.WriteLine("  -----------------------------");
          menu = Menu();
          Console.WriteLine(menu);
          Console.Write("  Choice: ");
          inputChoice = Console.ReadLine();
        }
        else
        {
          if (choice == 1)
          {
            Patient patient = createPatient();
            patients[validPatientIdx] = patient;
          }
          else if (choice == 2)
          {
            if (alreadyInput == true)
            {
              Console.Clear();
              TruongHeading.getHeading(APP_NAME);
              listPatients(patients);
              Console.WriteLine("\n  Enter a patient number to display a patient's");
              Console.WriteLine("  info, or type 'q' to return to the main menu");
              string getInput = Console.ReadLine();
              int patientNum;
              bool IsPatientNum = Int32.TryParse(getInput, out patientNum);

              if (getInput == "q")
              {
                //continue;
              }
              else if (IsPatientNum)
              {
                displayPatient(patients[patientNum]);
              }
            }
            else
            {
              Console.Clear();
              TruongHeading.getHeading(APP_NAME);
              Console.WriteLine("No patients. Press enter to return to the main menu.");
              Console.ReadLine();
            }
          }
          else if (choice == 3)
          {
            System.Environment.Exit(1);
          }
          else
          {
            Console.WriteLine("  Error! Enter a number from 1 to 3");
            menu = Menu();
            Console.WriteLine(menu);
            Console.Write("  Choice: ");
            inputChoice = Console.ReadLine();
          }
        }
      } 
      return choice;
    }

    static Patient createPatient()
    {
      validPatientIdx++;
      Console.Clear();
      TruongHeading.getHeading(APP_NAME);
      Console.Write("  Please enter patient's first name: ");
      String fName = Console.ReadLine();
      Console.Write("  Please enter patient's last name: ");
      String lName = Console.ReadLine();
      Console.Write("  Please enter patient's age: ");
      String age = Console.ReadLine();
      int ageNum;
      bool checkAge = false;
      while (!checkAge)
      {
        if (!int.TryParse(age, out ageNum))
        {
          Console.WriteLine("  Error! Age must be a numeric value only.");
          Console.Write("  Please enter patient's age: ");
          age = Console.ReadLine();
        }
        else{
          if (Convert.ToInt32(age) <= 0)
          {
            Console.WriteLine("  Error! Age must be a positive number only.");
            Console.Write("  Please enter patient's age: ");
            age = Console.ReadLine();
          }
          else
          {
            checkAge = true;
            alreadyInput = true;
          }
        }
      }
      Console.Write("  Please enter patient's weight in pounds: ");
      String weightInPounds = Console.ReadLine();
      int weightNum;
      bool checkWeight = false;
      while (!checkWeight)
      {
        if (!int.TryParse(weightInPounds, out weightNum))
        {
          Console.WriteLine("  Error! Weight must be a numeric value only.");
          Console.Write("  Please enter patient's weight: ");
          weightInPounds = Console.ReadLine();
        }
        else
        {
          if (Convert.ToInt32(weightInPounds) <= 0)
          {
            Console.WriteLine("  Error! Weight must be a positive number only.");
            Console.Write("  Please enter patient's weight: ");
            weightInPounds = Console.ReadLine();
          }
          else
          {
            checkWeight = true;
            alreadyInput = true;
          }
        }
      }
      Console.Write("  Please enter patient's height in inches: ");
      String heightInInches = Console.ReadLine();
      int heightNum;
      bool checkHeight = false;
      while (!checkHeight)
      {
        if (!int.TryParse(heightInInches, out heightNum))
        {
          Console.WriteLine("  Error! Height must be a numeric value only.");
          Console.Write("  Please enter patient's height: ");
          heightInInches = Console.ReadLine();
        }
        else
        {
          if (Convert.ToInt32(heightInInches) <= 0)
          {
            Console.WriteLine("  Error! Height must be a positive number only.");
            Console.Write("  Please enter patient's height: ");
            heightInInches = Console.ReadLine();
          }
          else
          {
            checkHeight = true;
            alreadyInput = true;
          }
        }
      }
      Patient patient = new Patient(fName, lName, Convert.ToInt32(age), Convert.ToDouble(weightInPounds),
        Convert.ToDouble(heightInInches));
      return patient;
    }

    static void listPatients(Patient[] patients)
    {
      Console.WriteLine("{0, -20}{1, -20}{2}", "  Patient Number", "Last Name", "First Name");
      Console.WriteLine("  -----------------------------------------------------------");
      for (int i = 1; i <= validPatientIdx; i++)
      {
        Console.WriteLine("  {0,-18}{1, -20}{2}", i, patients[i].lastName, patients[i].firstName);
      }
    }
    static void displayPatient(Patient p)
    {
      Console.Clear();
      TruongHeading.getHeading(APP_NAME);
      Console.WriteLine("  ---------------------------------------");
      Console.WriteLine("  Patient Information");
      Console.WriteLine("  ---------------------------------------");
      Console.WriteLine("  {0, -25}: {1}", "First Name", p.firstName.ToString());
      Console.WriteLine("  {0, -25}: {1}", "Last Name", p.lastName);
      Console.WriteLine("  {0, -25}: {1}", "Age", p.age);
      Console.WriteLine("  {0, -25}: {1}", "Height (inches)", p.heightInInches);
      Console.WriteLine("  {0, -25}: {1}", "Weight (pounds)", p.weightInPounds);
      Console.WriteLine("  ---------------------------------------");
      Console.WriteLine("  Body Mass Index");
      Console.WriteLine("  ---------------------------------------");
      Console.WriteLine("  {0, -25}: {1:0.00}", "BMI", GetBMIValue(p.weightInPounds, p.heightInInches));
      Console.WriteLine(GetBMIName(p.weightInPounds, p.heightInInches));
      Console.WriteLine("  ---------------------------------------");
      Console.WriteLine("  Heart Rate Info");
      Console.WriteLine("  ---------------------------------------");
      Console.WriteLine("  {0, -25}: {1}", "Max Heart Rate", GetMaxinumHeartRate(p.age));
      Console.WriteLine("  {0, -25}: {1}", "Max Target Heart Rate", GetMaxTargetHeartRate(p.age));
      Console.WriteLine("  {0, -25}: {1}", "Min Target Heart Rate", GetMinTargetHeartRate(p.age));
      Console.WriteLine("  Press enter to return to main screen.");
      Console.ReadLine();
    }
  }
}