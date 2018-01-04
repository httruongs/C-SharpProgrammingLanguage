/*	BowersHeading.cs  W. Bowers (c) 2016 All Rights Reserved.
 *  This application may be used with my permission provided:  1) this copyright
 *  notice remains in place and unaltered; 2) not one word of code or syntax may
 *  be altered without specific, written instructions and permission; 3) the next
 *  user adds their modification notice to the existing audit trail; and 4) 
 *  permission to use automatically ends at the completion of this course.
 *  Additional modifications by H. Truong, 2016
*/
using System;

namespace Truong_6
{
  class MultiplicationGame
  {
    private Random rd = new Random();
    public int randomNumber1, randomNumber2;

    public MultiplicationGame()
    {
    }

    public MultiplicationGame(int levelNumber)
    {
      switch (levelNumber)
      {
        case 1: //easy
          randomNumber1 = rd.Next(1, 9);
          randomNumber2 = rd.Next(1, 9);
          break;
        case 2: //medium
          randomNumber1 = rd.Next(1, 99);
          randomNumber2 = rd.Next(1, 99);
          break;
        case 3: //hard
          randomNumber1 = rd.Next(1, 1000);
          randomNumber2 = rd.Next(1, 1000);
          break;
        default:
          randomNumber1 = rd.Next(1, 9);
          randomNumber2 = rd.Next(1, 9);
          break;
       }
    }

    public int multiply()
    {
      return randomNumber1 * randomNumber2;
    }
   
  }
}
