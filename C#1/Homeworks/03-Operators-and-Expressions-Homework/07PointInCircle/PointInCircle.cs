using System;
using System.Threading;
using System.Globalization;

//Write a program that reads the coordinates of a point x and y and 
//using an expression checks if given point (x, y) is inside a circle  

//K({0, 0}, 2)  - the center has coordinates (0, 0) and the circle has radius 2.

//The program should then print "yes DISTANCE" if the point is inside the circle 
//or "no DISTANCE" if the point is outside the circle.
//In place of DISTANCE print the distance from the beginning of the 
//coordinate system - (0, 0) - to the given point.

//input : 
//exactly two lines, the first containing the x coordinate, 
//the second containing the y coordinate.

//output :
//single line in the format described above. 
//The distance should be always printed with 2-digit precision after the 
//floating point.


    class PointInCircle
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            float radius = 2f;
            float xc = 0.0f;
            float yc = 0.0f;

            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
                       
            //float dx = Math.Abs(x - xc); -> dx = x
            //float dy = Math.Abs(y - yc); -> dy = y
            //double distance = Math.Sqrt((dx * dx) + (dy * dy));

            double distance = Math.Sqrt((x * x) + (y * y));

            bool isInside = (distance <= radius) ? true : false;

            if (isInside) 
            { 
                Console.Write("yes "); 
            }
            else
            { 
                Console.Write("no ");  
            }
            Console.Write("{0:f2}\n",distance);
        }
    }
