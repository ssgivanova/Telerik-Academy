
/*
You are given a sequence of positive integer values written into a string, separated by spaces. 
Write a function that reads these values from given string and calculates their sum..

Input
•On the only line you will receive a string consisted of positive integers

Output
•Print the sum of the integers

Constraints
•Each number will be in the interval  [ 1, 1000 ] 
•There will not be more than 1000 numbers
•Time limit: 0.1s
•Memory limit: 16MB
 * 
43 68 9 23 318  -> result 461 

 */
using System;
using System.Linq;
class SumIntegers
{
   static void Main()
   {
       string input = Console.ReadLine();
       string[] numbers = input.Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);

       int sum = 0;
       for (int i = 0; i < numbers.Length; i++)
       {
           sum += int.Parse(numbers[i]);
       }
       Console.WriteLine(sum);

       //solution with lambda expressions
       Console.WriteLine("Add several numbers to find their sum");
       int[] nums = Console.ReadLine()
                    .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

       int sumLambda = nums.Sum();
       Console.WriteLine(sumLambda);
   }
}
