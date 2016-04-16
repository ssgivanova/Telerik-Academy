using System;
using System.Threading;
using System.Globalization;
using System.Numerics;

//Write a program that, for a given two integer numbers N and x, calculates the sum 
//S = 1 + 1!/x + 2!/x2 + … + N!/xN.
//•Use only one loop. Print the result with 5 digits after the decimal point.

//Input
//•On the first line you will receive one number - N.
//•On the second line you will receive another number - x.

//Output
//•Output only one number - the sum of the sequence for the given N and x.

//Constraints
//•N will always be a valid integer between 2 and 20, inclusive.
//•X will always be a valid floating-point number between 0 and 100
//•X * N will always be less than 50


class Calculate
{
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double sum = 1;
            int factoriel = 1;
            double pow = 1;

            if (x == 0)
            {
                Console.WriteLine("invalid input - division by zero");
            }

            //S = 1 + 1!/x + 2!/x2 + … + N!/xN.

            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
                pow *= x;
                sum += factoriel / pow;            
            }
            Console.WriteLine("{0:f5}",sum);
        }
}
