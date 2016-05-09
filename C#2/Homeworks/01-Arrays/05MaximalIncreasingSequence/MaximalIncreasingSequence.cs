using System;
/*
Write a program that finds the length of the maximal increasing sequence in an array of N integers.

Input
•On the first line you will receive the number N
•On the next N lines the numbers of the array will be given

Output
•Print the length of the maximal increasing sequence

Constraints
•1 <= N <= 1024
•Time limit: 0.1s
•Memory limit: 16MB
 */


class MaximalIncreasingSequence
{
   static void Main()
   {
       int n = int.Parse(Console.ReadLine());

       int count = 1;
       int maxIncreasingCount = 1;

       int[] arr = new int[n];
       for (int i = 0; i < n; i++)
       {
           arr[i] = int.Parse(Console.ReadLine());
       }

       for (int i = 0; i < n-1; i++)
       {
           if (arr[i] < arr[i + 1])
           {
               count++;
               if (count > maxIncreasingCount)
               {
                   maxIncreasingCount = count;
               }
           }
           else
           {
               count = 1;
           }
       }
       Console.WriteLine(maxIncreasingCount);
   }
}
