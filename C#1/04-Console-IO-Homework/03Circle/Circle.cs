using System;
using System.Threading;
using System.Globalization;

//Write a program that reads from the console the radius r of a circle and prints its perimeter and area,
//rounded and formatted with 2 digits after the decimal point.

//Input
//On the only line of the input you will receive the radius of the circle - r

//Output
//You should print one line only: the perimeter and the area of the circle, separated by a whitespace, 
//and with 2 digits precision

//The radius r will always be a valid and positive real number

class Circle
{
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            float r = float.Parse(Console.ReadLine());

            if (r <= 0)
            {
                Console.WriteLine("invalid parameter");
            }
            else
            {
                double permiter = 2 * Math.PI * r;
                double area = Math.PI * r * r;

                Console.WriteLine("{0:f2} {1:f2}", permiter, area);
            }

        }
}
