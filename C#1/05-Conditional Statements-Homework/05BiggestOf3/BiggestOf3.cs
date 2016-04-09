using System;
using System.Threading;
using System.Globalization;

//Write a program that finds the biggest of three numbers that are read from the console.

//Input
//•On the first three lines you will receive the three numbers, each on a separate line.

//Output
//•On the only output line, write the biggest of the three numbers.

//Constraints
//•The three numbers will always be valid floating-point numbers in the range  [-200, 200] .


class BiggestOf3
{
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            float max = 0.0f;

            //equal numbers
            if (a == b && b == c && a == c)
            {
                max = a;
            }
            else
            {
                // a is biggest
                if (a > b && a > c)
                {
                    max = a;
                }
                // b is biggest
                else if (b > a && b > c)
                {
                    max = b;
                }
                // c is biggest
                else if (c > a && c > b)
                {
                    max = c;
                }
            }
            Console.WriteLine(max);
        }
}
