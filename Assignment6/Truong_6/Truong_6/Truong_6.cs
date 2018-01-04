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


namespace Truong_6
{
  class Truong_6
  {
    private static int maxQuestion = 0;
    private static int correctNumAnswer, incorrectNumAnswer = 0;

    public static string errorMessage(String message)
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(String.Format("  xxxxxxxxxxxxxxxxxxxxxxxxxx ERROR xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n"));
      sb.Append(String.Format(message));
      sb.Append(String.Format("  xxxxxxxxxxxxxxxxxxxxxxxxxx ERROR xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n"));
      string errMessage = sb.ToString();
      return errMessage;
    }

    static bool GetMaxQuestion()
    {
      bool whileCheck = true;
      while (whileCheck)
      {
        Console.Write("  Please input the number of question you want to play (max 20): ");
        bool isInteger = int.TryParse(Console.ReadLine(), out maxQuestion);
        if (!isInteger)
        {
          Console.WriteLine(errorMessage("  Please enter a numeric value only!\n"));
        }
        else if ((maxQuestion <= 0) || (maxQuestion > 20))
        {
          Console.WriteLine(errorMessage("  Please enter a value less than 20 and greater than 0\n"));
        }
        else
        {
          whileCheck = false;
        }
      }//end while
      return whileCheck;
    }

    static void printResult()
    {
      Console.WriteLine("  ====== Score ======");
      Console.WriteLine("  Asked: " + maxQuestion.ToString());
      Console.WriteLine("  Correct: " + correctNumAnswer.ToString());
      Console.WriteLine("  Incorrect: " + incorrectNumAnswer.ToString());
      Console.WriteLine("  ====== Score ======");
    }

    static void updateScore()
    {
      int posLeft = Console.CursorLeft;
      int posTop = Console.CursorTop;

      Console.SetCursorPosition(Console.WindowWidth - 25, 2);
      Console.WriteLine("  ====== Score ======");
      Console.SetCursorPosition(Console.WindowWidth - 25, 3);
      Console.WriteLine("  Asked: " + maxQuestion.ToString());
      Console.SetCursorPosition(Console.WindowWidth - 25, 4);
      Console.WriteLine("  Correct: " + correctNumAnswer.ToString());
      Console.SetCursorPosition(Console.WindowWidth - 25, 5);
      Console.WriteLine("  ===================");
    }


    static void Main(string[] args)
    {

      TruongHeading.getHeading("Assignment 6");
      bool whileCheck = GetMaxQuestion();

      int levelInput = 0;
      bool levelCheck = true;
      while (levelCheck && whileCheck == false)
      {
        Console.Write("  Please input the difficulty level (1 = easy, 2 = medium, 3 = hard): ");
        String input1 = Console.ReadLine();
        if (!int.TryParse(input1, out levelInput))
        {
          Console.WriteLine(errorMessage("  Please input a numeric value only!\n"));
        }
        else if ((levelInput <= 0) || (levelInput > 3))
        {
          Console.WriteLine(errorMessage("  Please enter a value between 1 and 3 only.\n"));
        }
        else
        {
          levelCheck = false;
        }
      }

      int userResult = 0;
      MultiplicationGame multiplicationGame;
      int counter = 0;

      while (true)
      {
        counter++;
        multiplicationGame = new MultiplicationGame(levelInput);
        Console.Clear();
        TruongHeading.getHeading("Assignment 6");
        updateScore();
        Console.Write("\n  How much is {0} times {1}? ", multiplicationGame.randomNumber1, multiplicationGame.randomNumber2);
        String result = Console.ReadLine();

        if (!int.TryParse(result, out userResult))
        {
          Console.WriteLine(errorMessage("  Error - please enter a numeric answer only!\n"));
          Console.WriteLine("  Please press enter to continue");
        }
        else
        {
          if (userResult != multiplicationGame.multiply())
          {
            Console.WriteLine("  Incorrect!\n  Press enter to continue");
            incorrectNumAnswer++;
            Console.ReadLine();
          }
          else
          {
            Console.WriteLine("  Correct!\n  Press enter to continue");
            correctNumAnswer++;
            Console.ReadLine();
          }
        }

        if (counter == maxQuestion)
        {
          Console.Clear();
          TruongHeading.getHeading("Assignment 6");
          printResult();
          break;
        }
      }
      Console.ReadLine();
    }

  }
}

