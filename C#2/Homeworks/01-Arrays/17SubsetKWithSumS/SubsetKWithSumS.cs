using System;
using System.Collections.Generic;
/*
 Write a program that reads three integer numbers  N ,  K  and  S  and an array of  N  elements 
 from the console.
 Find in the array a subset of  K  elements that have sum  S  or indicate about its absence.
 * 
 n=8
 k=4
 2
 1
 2
 4
 3
 5
 2
 6
 s=14  

 * */

class SubsetKWithSumS
{
   static void Main()
   {
       int n = int.Parse(Console.ReadLine());
       int k = int.Parse(Console.ReadLine());

       bool hasSum = false;

       int[] arr = new int[n];
       for (int i = 0; i < n; i++)
       {
           arr[i] = int.Parse(Console.ReadLine());
       }

       int sum = int.Parse(Console.ReadLine());

       int count = 1;
       int combinations = (int)Math.Pow(2, n) - 1;
       for (int i = 0; i < combinations; i++)
       {
           count = 1; // count how many elements we have
           int currentSum = 0;
           List<int> subsets = new List<int>();

           for (int j = 0; j < n; j++)
           {
               int bit = ((1 << j) & i) >> j;
               if (bit == 1)
               {
                   currentSum += arr[j];
                   subsets.Add(arr[j]);
                   count++;

                   if (currentSum == sum && count ==k)
                   {
                          hasSum = true;
                          Console.WriteLine("has sum {0} - {1}", sum, hasSum); 
                          foreach (var item in subsets)
                          {
                              Console.Write(item + " ");
                          }
                          break;
                   }
               }
           }
       }
   }
}
