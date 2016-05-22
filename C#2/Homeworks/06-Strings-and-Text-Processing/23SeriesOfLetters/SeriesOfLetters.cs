/*
Write a program that reads a string from the console and replaces all series of consecutive 
identical letters with a single one.

Input
•On the only input line you will receive a string

Output
•Print the string without consecutive identical letters

Constraints
•Time limit: 0.1s
•Memory limit: 16MB

aaaaabbbbbcdddeeeedssaa -> abcdedsa 
 
 * */

using System;
using System.Text;

class SeriesOfLetters
{
  static void Main()
  {
      string input = Console.ReadLine();

      StringBuilder sb = new StringBuilder();

      int count = 1;
      //append first letter and compare the next ones consecutive starting from the second letter in text
      //compare each letter with previous
      sb.Append(input[0]);
      for (int i = 1; i < input.Length; i++)
      {
          if (input[i-1] == input[i])
          {
              count++;
          }
          else
          {
              count = 1;
              sb.Append(input[i]);
          }
      }

      Console.WriteLine(sb.ToString());
  }
}
