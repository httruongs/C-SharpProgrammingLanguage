using System;

namespace Truong_7
{
  public class Patient
  {
    public Patient(string fName, string lName, int ages, double weightPounds, double heightInches)
    {
      firstName = fName;
      lastName = lName;
      age = ages;
      weightInPounds = weightPounds;
      heightInInches = heightInches;
    }
    public string firstName
    {
      set;
      get;
    }
    public string lastName
    {
      set;
      get;
    }
    public int age
    {
      set;
      get;
    }
    public double weightInPounds
    {
      set;
      get;
    }
    public double heightInInches
    {
      set;
      get;
    }
  }
}
