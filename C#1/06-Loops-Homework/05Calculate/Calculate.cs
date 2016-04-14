using System;
using System.Threading;
using System.Globalization;

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
            int x = int.Parse(Console.ReadLine());

            float sum = 0f;
            int factoriel = 1;
            int pow = 1; 

            //S = 1 + 1!/x + 2!/x2 + … + N!/xN.

            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    factoriel = 1;
                    pow = 1;
                }
                else
                {
                    factoriel = factoriel * i;
                    pow *= x;
                }
                sum += (float)factoriel / pow;
                //Console.WriteLine("i={0} -> {1}/{2}", i,factoriel,pow);              
            }
            Console.WriteLine("{0:f5}",sum);
        }
}
