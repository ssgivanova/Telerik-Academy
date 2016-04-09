using System;
using System.Threading;
using System.Globalization;

//Write a program that finds the biggest of 5 numbers that are read from the console, 
//using only 5 if statements.

//Input
//•On the first 5 lines you will receive the 5 numbers, each on a separate line

//Output
//•On the only output line, write the biggest of the 5 numbers

//Constraints
//•The 5 numbers will always be valid floating-point numbers in the range  [-200, 200] 

class BiggestOf5
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());
            float e = float.Parse(Console.ReadLine());

            float max = 0.0f;

            if (a == b && b == c && c == d && d == e && e == a)
            {
                max = a;
            }
            else
            {
                if (a > b && a > c && a > d && a > e)
                {
                    max = a;
                }
                else if (b > a && b > c && b > d && b > e)
                {
                    max = b;
                }
                else if (c > a && c > b && c > d && c > e)
                {
                    max = c;
                }
                else if (d > a && d > c && d > b && d > e)
                {
                    max = d;
                }
                else if (e > a && e > c && e > d && e > b)
                {
                    max = e;
                }
            }
            

            Console.WriteLine(max);
        }
}
