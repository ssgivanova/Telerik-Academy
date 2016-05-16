using System;
using System.Collections.Generic;
/*
Write a method that returns the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order. 
Write a program that sorts a given array.

Input
•On the first line you will receive the number N - the size of the array
•On the second line you will receive N numbers separated by spaces - the array

Output
•Print the sorted array ◦Elements must be separated by spaces


Constraints
•1 <= N <= 1024
•Time limit: 0.1s
•Memory limit: 16MB
 * 
6
3 4 1 5 2 6 -> 1 2 3 4 5 6

 * */
class SortingArray
{
   static void Main()
   {
       int n = int.Parse(Console.ReadLine());
       int[] arr = new int[n];

       //read numbers
       string[] numbers = Console.ReadLine().Split();

       for (int i = 0; i < arr.Length; i++)
       {
           arr[i] = int.Parse(numbers[i]);
       }
       int max = 0;
       for (int i = 0; i < arr.Length; i++)
       {
           max = GetMaxElementArrayFromIndex(arr, i);
           int indexMax = GetIndexAtMax(max, arr);
           
           int temp = arr[i];
           arr[i] = arr[indexMax];
           arr[indexMax] = temp;
       }

       Array.Reverse(arr);

       //print sorted array
       PrintArray(arr);
   }
   static int GetMaxElementArrayFromIndex(int[] arr, int start)
   {
       int max = Int32.MinValue;
       for (int i = start; i < arr.Length; i++)
       {
           if (arr[i] > max)
           {
               max = arr[i];
           }
       }
       return max;
   }

   static int GetIndexAtMax(int maxNumber, int[] arr)
   {
       int indexMax = 0;
       for (int i = 0; i < arr.Length; i++)
       {
           if (arr[i] == maxNumber)
           {
               indexMax = i;
           } 
       }       
       return indexMax;
   }

   static void PrintArray(int[] arr)
   {
       foreach (int item in arr)
       {
           Console.Write(item + " ");
       }
   }
}
