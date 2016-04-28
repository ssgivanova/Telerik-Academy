using System;

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//• If the score is between 1 and 3, the program multiplies it by 10.
//• If the score is between 4 and 6, the program multiplies it by 100.
//• If the score is between 7 and 9, the program multiplies it by 1000.
//• If the score is less than 0 or more than 9, the program prints "invalid score".

//Input
//•The only input line will contain one integer number - the score

//Output
//•Output the score with the applied bonus


class BonusScore
{
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int score = 0;

            if (n >= 1 && n <= 9)
            {
                if (n >= 1 && n <= 3)
                {
                    score = n * 10;
                }
                else if (n >= 4 && n <= 6)
                {
                    score = n * 100;
                }
                else
                {
                    score = n * 1000;
                }
                Console.WriteLine(score);
            }
            else
            {
                Console.WriteLine("invalid score");
            }

        }
}
