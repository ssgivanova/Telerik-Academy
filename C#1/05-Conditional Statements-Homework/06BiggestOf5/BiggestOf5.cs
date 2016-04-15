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

            float max = a;

            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            if (d > max)
            {
                max = d;
            }
            if (e > max)
            {
                max = e;
            }
            
            Console.WriteLine(max);
        }
}
