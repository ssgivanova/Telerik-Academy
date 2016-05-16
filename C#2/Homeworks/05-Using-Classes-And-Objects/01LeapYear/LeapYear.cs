/*
Write a program that reads a year from the console and checks whether it is a leap one.

Hint: Use  System.DateTime .

Input
•On the only line you will receive a number - the year

Output
•Print "Leap" or "Common" on a single line depending on the year

Constraints
•Time limit: 0.1s
•Memory limit: 16MB
 
 */
using System;
class LeapYear
{
   static void Main()
   {
       int year = int.Parse(Console.ReadLine());

       if (DateTime.IsLeapYear(year))
       {
           System.Console.WriteLine("Leap");
       }
       else
       {
           System.Console.WriteLine("Common");
       }
   }
}
