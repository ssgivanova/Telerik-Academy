using System;
using System.Threading;
using System.Globalization;

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and 
//solves it (prints its real roots).

//Input
//•On the first three lines, you will receive the coefficients a, b, and c, each on a separate line 
//in the same order

//Output
//•If two different real roots exist, print them on two separate lines 
//◦Print the smaller root on the first line

//•If only one real root exists, print it on the only output line
//•If no real root exists, print the string "no real roots"
//•The roots, should they exist, must be printed with precision exactly two digits after the floating point

//Constraints
//•The input will always consist of valid real numbers in the range [-1000, 1000] and will follow the 
//described format



class QuadraticEquation
{
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            double x1, x2, x;

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                //2 real roots
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine((x1 < x2) ? "{0:f2}\n{1:f2}" : "{1:f2}\n{0:f2}", x1, x2);

            }
            else if (discriminant == 0)
            {
                //1 real root
                x = -b / (2 * a);
                Console.WriteLine("{0:f2}",x);
            }
            else
            {
                //no real roots
                Console.WriteLine("no real roots");
            }            
        }
}
