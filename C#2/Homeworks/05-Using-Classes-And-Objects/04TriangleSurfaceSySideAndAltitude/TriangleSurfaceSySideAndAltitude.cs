using System;
/*
 Write program that calculates the surface of a triangle by given a side and an altitude to it.

Input
•On the first line you will receive the length of a side of the triangle
•On the second line you will receive the altitude to that side

Output
•Print the surface of the rectangle with two digits of precision

Constraints
•Input data describes a valid triangle
•Time limit: 0.1s
•Memory limit: 16MB

 23.2
 5 
 result -> 58.00 
 * 
 */
class TriangleSurfaceSySideAndAltitude
{
   static void Main()
   {
       decimal a = decimal.Parse(Console.ReadLine());
       decimal h = decimal.Parse(Console.ReadLine());
       decimal surface = (a * h) / 2;

       Console.WriteLine("{0:f2}",surface);
   }
}
