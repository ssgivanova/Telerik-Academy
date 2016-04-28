using System;
using System.Threading;
using System.Globalization;

//Write a program that reads an integer number N from the console and prints all the numbers 
// the interval  [1, n] , each on a single line.

//Input
//•On the only line you will receive the number N

//Output
//•You should print the numbers from 1 to N, each on a separate line

//•1 <= N < 1000
//•N will always be a valid integer number

class NumbersFrom1ToN
{
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());

            while (n < 1 || n > 1000)
            {
                Console.WriteLine("invalid number");
                n = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

        }
}
