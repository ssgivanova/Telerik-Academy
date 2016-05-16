using System;
/*
Write program that calculates the surface of a triangle by given its three sides.

Input
•On the first line you will receive the length of the first side of the triangle
•On the second line you will receive the length of the second side of the triangle
•On the third line you will receive the length of the third side of the triangle

Output
•Print the surface of the rectangle with two digits of precision

Constraints
•Input data describes a valid triangle
•Time limit: 0.1s
•Memory limit: 16MB

11
12
13 
result -> 61.48 

 */
class TriangleSurfaceByThreeSides
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());

        decimal p = a + b + c;
        decimal s = p / 2;
        decimal surfacePower2 = (s * (s - a) * (s - b) * (s - c));
        double surface = Math.Sqrt((double)surfacePower2);

        Console.WriteLine("{0:f2}", surface);
    }
}
