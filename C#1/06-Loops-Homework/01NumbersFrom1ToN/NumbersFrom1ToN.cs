using System;

//Write a program that enters from the console a positive integer n and prints all the numbers 
//from 1 to N inclusive, on a single line, separated by a whitespace.

//Input
//•The input will consist of a single line - the number N

//Output
//•The output should consist of a single line - the numbers from 1 to N, separated by a whitespace

//N will be a valid positive 32-bit integers


class NumbersFrom1ToN
 {
      static void Main()
      {
          int n = int.Parse(Console.ReadLine());

          for (int i = 1; i <= n; i++)
          {
              Console.Write("{0} ",i); 
          }
      }
}
