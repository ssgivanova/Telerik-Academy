using System;
using System.Threading;
using System.Globalization;

//Write an expression that calculates trapezoid's area by given sides a and b 
//and height h. The three values should be read from the console in the order 
//shown below. All three value will be floating-point numbers.

//input :
//will consist of exactly 3 lines: 
//i.The side a on the first line.
//ii.The side b on the second line.
//iii.The height h on the third line.

//output :
//single line containing a single value - the area of the trapezoid. 
//Output the area with exactly 7-digit precision after the floating point.

    class Trapezoid
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());

            float area = h * (a + b) / 2;

            if (a + b < 0)
            {
                area = 0; // error
            }

            Console.WriteLine("{0:f7}",area);
        }
    }
