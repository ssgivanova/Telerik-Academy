using System;
using System.Threading;
using System.Globalization;

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//•Use nested  if  statements.
//•Don’t use arrays and the built-in sorting functionality.

//Input
//•On the first three lines, you will receive the three numbers, each on a separate line.

//Output
//•Output a single line on the console - the sorted numbers, separated by a whitespace

//Constraints
//•The three numbers will always be valid integer numbers in the range  [-1000, 1000] 


class Sort3Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());

        float min = float.MinValue;
        float middle = float.MinValue;
        float max = float.MaxValue;

        if (a == b && b == c && c == a)
        {
            min = max = middle = a;
        }
        else
        {
            if (a > b && a > c)
            {
                max = a;
                if (b > c)
                {
                    middle = b;
                    min = c;
                }
                else
                {
                    middle = c;
                    min = b;
                }
            }
            else if (b > a && b > c)
            {
                max = b;
                if (a > c)
                {
                    middle = a;
                    min = c;
                }
                else
                {
                    middle = c;
                    min = a;
                }
            }
            else if (c > a && c > b)
            {
                max = c;
                if (a > b)
                {
                    middle = a;
                    min = b;
                }
                else
                {
                    middle = b;
                    min = a;
                }
            }
        }

        

        Console.WriteLine("{0} {1} {2}", max,middle,min);

    }
}
