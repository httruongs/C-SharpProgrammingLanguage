/* Deitel, H. and Deitel, P. (2014). Visual C# 2012, How to Program,
Fifth Edition. Upper Saddle River, New Jersey: Pearson Education.
Modifications by W. Bowers, 2016
Additional modifications by H. Truong, 2016
*/

using System;

    class Assignment2
    {
        static void Main(string[] args)
        {
            TruongHeading.getHeading("Assignment 2");
            Console.WriteLine("  Exponents and Roots Application\n");
            Console.Write("  Exponents ---------------------|"+"   Roots ------------------------------------|" );
            Console.WriteLine("{0,2}{1,4}{2,7}{3,10}  {4,-10}  {5,-7}  {6,-4}  {7,-2}", "  Number", "  Square" ,"Cube",
                "  Fifth", "  Fourth", " Seventh", "  Twelfth", "  Fifteenth");
            Console.WriteLine("{0,2} {1,5}{2,7}{3,10}   {4,-10}  {5,-7}  {6,-4}  {7,-2}", "  ------",  " ------",
                " ----", "-----",  " ------", "-------",   "  -------",        "  ---------");
            for(int i = 1; i <= 15; i ++)
            {
                Console.WriteLine(String.Format("{0,6}{1,8}{2,9:,0}{3,10:,0}     {4,-11:0.00}{5,-9:0.000}  {6,-10:0.0000} {7,-9:0.00000}",
                    i, Math.Pow(i, 2.0), Math.Pow(i, 3.0), Math.Pow(i, 5.0), Math.Pow(i, (1.0 / 4.0)), Math.Pow(i, (1.0 / 7.0)),
                    Math.Pow(i, (1.0 / 12.0)), Math.Pow(i, (1.0 / 15.0))));                       
            }
            TruongHeading.getClosing();
        }
    }

