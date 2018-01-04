/*	BowersHeading.cs  W. Bowers (c) 2016 All Rights Reserved.
 *  This application may be used with my permission provided:  1) this copyright
 *  notice remains in place and unaltered; 2) not one word of code or syntax may
 *  be altered without specific, written instructions and permission; 3) the next
 *  user adds their modification notice to the existing audit trail; and 4) 
 *  permission to use automatically ends at the completion of this course.
 *  Additional modifications by H. Truong, 2016
*/
using System;


namespace Truong_5
{
  class Person
  {
 
   private double BMI;

    public Person(int height, double weight)
    {
      heightInInches = height;
      weightInPound = weight;
    }
    public double weightInPound
    {
      set;
      get;
    }
    public int heightInInches
    {
      set;
      get;
    }
    public double BMIValue
    {
      get{
        return BMI = (weightInPound * 703) / (heightInInches * heightInInches);
        }
    }
    public String BMIName
    {
      get
      {
        string retVal = "";
        if (BMI < 18.5)
          retVal = String.Format("  Your BMI is {0:0.00}, which is considered is Underweight", BMIValue);
        else if (18.5 < BMI && BMI < 24.9)
          retVal = String.Format("  Your BMI is {0:0.00}, which is considered is Normal", BMIValue);
        else if (25 < BMI && BMI < 29.9)
          retVal = String.Format("  Your BMI is {0:0.00}, which is considered is Overweight", BMIValue);
        else if (BMI >= 30)
          retVal =  String.Format("  Your BMI is {0:0.00}, which is considered is Obese", BMIValue);
        return retVal;
      }
    }

  }
}
