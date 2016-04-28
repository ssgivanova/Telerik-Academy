using System;
using System.Threading;
using System.Globalization;
using System.Numerics;

//Write a program that reads from the console a sequence of N integer numbers and returns the minimal, 
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal 
//point).
//•The input starts by the number N (alone in a line) followed by N lines, each holding an integer number.
//•The output is like in the examples below.

//Input
//•On the first line, you will receive the number N.
//•On each of the next N lines, you will receive a single floating-point number.

//Output
//•You output must always consist of exactly 4 lines - the minimal element on the first line, the maximal 
//on the second, the sum on the third and the average on the fourth, in the following format:

//min=3
//max=6
//sum=9
//avg=4.5


class MinMaxSumAverage
{
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            
            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            double avg = 0;

            //read the first number and initialize min and max to it
            double num = double.Parse(Console.ReadLine());
            double min = num;
            double max = num;
            sum += num;

            for (int i = 0; i < n-1; i++)
            {
                num = double.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
                sum += num;
            }

            avg =  sum / n;

            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", avg);
        }
}
