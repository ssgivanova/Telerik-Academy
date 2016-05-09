using System;
/*
Write a program that finds in given array of integers a sequence of given sum  S  (if present).

array : 4, 3, 1, 4, 2, 5, 8
S     : 11
result: 4, 2, 5
 */

class FindSequenceOfGivenSum
{
   static void Main()
   {
       int n = 7;
       int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
       int sum = 11;

       bool hasSum = false;

       int currentSum = 0;
       int startIndex = 0;
       int endIndex = 0;

       for (int i = 0; i < arr.Length; i++)
       {
           currentSum = 0;
           int count = 1;
           //Console.WriteLine(i);
           for (int j = i; j < arr.Length; j++)
           {
               currentSum += arr[j];

               //Console.WriteLine("currentSum=" + currentSum);
               if (currentSum >= sum)
               {
                   if (currentSum == sum)
                   {
                       hasSum = true;
                       count++;
                       endIndex = j;
                       startIndex = endIndex - count;
                   }
                   break;
               }
           }
           if (hasSum) { break; } //if we already found the sum we can stop
       }

       if (hasSum)
       {
           Console.Write("elements with sum {0} : ", sum);
           //print elements
           for (int k = startIndex; k <= endIndex; k++)
           {
               Console.Write(arr[k] + " ");
           }
       }
       else
       {
           Console.WriteLine("no elements with sum {0} :", sum);
       }

   }
}
