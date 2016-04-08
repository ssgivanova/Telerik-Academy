using System;
using System.Threading;
using System.Globalization;

//Write an expression that calculates rectangle’s perimeter and area by given 
//width and height. 
//The width and height should be read from the console.

//input : 
//The input will consist of 2 lines: On the first line, you will receive a 
//floating-point number that will represent the width of the rectangle.
//On the second line, you will receive another floating-point number that will 
//represent the height of the rectangle.

//output :
//a single line - the rectangle's perimeter and area, separated by a whitespace.
//Print the perimeter and area values with exactly 2-digits precision after 
//the floating point



class Rectangles
{
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());

            float permiter = 2 * (width + height);
            float area = width * height;

            Console.WriteLine("{0:0.00} {1:0.00}", area, permiter);
        }
}
