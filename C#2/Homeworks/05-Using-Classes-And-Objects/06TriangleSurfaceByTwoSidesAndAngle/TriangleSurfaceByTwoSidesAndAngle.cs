using System;
/*
Write program that calculates the surface of a triangle by given two sides and an angle between them.

Input
•On the first line you will receive the length of the first side of the triangle
•On the second line you will receive the length of the second side of the triangle
•On the third line you will receive the angle between the given sides ◦Angle is given in degrees


Output
•Print the surface of the rectangle with two digits of precision

Constraints
•Input data describes a valid triangle
•Time limit: 0.1s
•Memory limit: 16MB

10
7
25
RESULT -> 14.79
 */

class TriangleSurfaceByTwoSidesAndAngle
{
    static void Main()
    {
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        int angle = int.Parse(Console.ReadLine());

        //angle in radians = angle in degrees * PI / 180
        decimal angleInRadians = (angle * (decimal)Math.PI) / 180.0m;

        //SURFACE = (B * C * SIN A)/2;
        decimal surface = (b * c * (decimal)Math.Sin((double)angleInRadians))/2.0m;
        Console.WriteLine("{0:f2}", surface);
    }
}
