using System;

//Write a program that reads an integer N from the console and prints true if 
//the third digit of the N is 7, or "false THIRD_DIGIT", where you should print 
//the third digits of N.
//The counting is done from right to left, meaning 123456's third digit is 4.

//input :
//will always consist of exactly one line, containing the number N.

//output :
//should be a single line - print whether the third digit is 7, 
//following the format described above.

    class ThirdDigit
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool thirdDigit7 = false;

            int nDivided = n / 100;
            int thirdDigit = nDivided % 10;
            if (thirdDigit == 7)
            {
                thirdDigit7 = true;
                Console.WriteLine("{0}",thirdDigit7.ToString().ToLower());
            }
            else
            {
                Console.WriteLine("{0} {1}",thirdDigit7.ToString().ToLower(),thirdDigit);
            }
            

        }
    }
