using System;
using System.Threading;
using System.Globalization;

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, 
//without calculating it.
//• Use a sequence of  if  operators.

//Input
//•On the first three lines, you will receive the three numbers, each on a separate line

//Output
//•Output a single line - the sign of the product of the three numbers

//2
//5
//2 + 


class MultiplicationSign
{
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            char sign = '+';

            //product is zero
            if (a == b || b == 0 || c == 0)
            {
                sign = '0';
            }
            else
            {
                //3 positive numbers
                if (a > 0 && b > 0 && c > 0)
                {
                    sign = '+';
                }
                //3 negative numbers
                if (a < 0 && b < 0 && c < 0)
                {
                   sign = '-';
                }

                //3 numbers with different sign
                if (a > 0)
                {
                    if ((b > 0 && c < 0) || (b < 0 && c > 0))
                    {
                        sign = '-';
                    }
                }
                else if (b > 0)
                {
                    if ((a > 0 && c < 0) || (a < 0 && c > 0))
                    {
                        sign = '-';
                    }
                }
                else if (c > 0)
                {
                    if ((b > 0 && a < 0) || (b < 0 && a > 0))
                    {
                        sign = '-';
                    }
                }
            }

            Console.WriteLine(sign);
        }
}
