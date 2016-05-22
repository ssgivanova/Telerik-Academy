/*
 * Write a program that reads from the console a string of maximum  20  characters. If the length of the string is less than  20 , the rest of the characters should be filled with  * .

Input
•On the only line you will receive a string

Output
•Output a string with length  20 

Constraints
•The length of the given string will be <= 20
•Time limit: 0.1s
•Memory limit: 16MB

 hello - > hello*************** 
 * */

using System;
using System.Text;
class StringLength
{
   static void Main()
   {
       string input = Console.ReadLine();

       int countStars = 0;
       int max = 20;

       input = input.Replace(@"\", string.Empty);       

       if (input.Length < max)
       {
           countStars = max - input.Length;
           Console.Write(input);
           Console.Write(new string('*', countStars));
       }
       else
       {
           Console.Write(input);

       }

       //SECOND SOLUTION - WITH PADLEFT
       //Console.WriteLine(input.Replace(@"\", string.Empty).PadRight(20, '*'));
   }
}
