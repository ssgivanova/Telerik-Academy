using System;
/*
 Write a program that sorts an array of integers using the Merge sort algorithm.

Input
•On the first line you will receive the number N
•On the next N lines the numbers of the array will be given

Output
•Print the sorted array ◦Each number should be on a new line


Constraints
•1 <= N <= 1024
•Time limit: 0.1s
•Memory limit: 16MB

 */

class MergeSort
{
   static void Main()
   {
       int n = int.Parse(Console.ReadLine());

       int[] arr = new int[n];
       for (int i = 0; i < n; i++)
       {
           arr[i] = int.Parse(Console.ReadLine());
       }

       //print array before sorting
       //for (int i = 0; i < arr.Length; i++)
       //{
       //    Console.Write(arr[i] + " ");
       //}

       //merge sort
       //divide the array in 2 equal subarrays
       //divide each subarray until they have size=1
       //merge the subarrays into temp array
       //copy the temp array into the initial array

       int[] tempArr = new int[arr.Length];

       CopyArray(arr, tempArr);
              
       //merge sort for 0 to n
       MergeSorting(arr, 0, n, tempArr);

       //print array after sorting
       for (int i = 0; i < arr.Length; i++)
       {
           Console.WriteLine(arr[i]);
       }
   }
   static void MergeSorting(int[] arr, int start, int end, int[] temp)
   {
       //until the size of the subarray is 1 split the array into subarrays
       if (end - start <= 1)
       {
           return;
       }
       int middle = (start + end) / 2;
       MergeSorting(arr, start, middle, temp);
       MergeSorting(arr, middle, end, temp);
       MergeSubarrays(start, middle, end, temp, arr);
       CopyArray(temp, arr);
   }

   static void MergeSubarrays(int start, int middle, int end, int[] temp,int[] arr)
   {
       int i = start;
       int j = middle;
       for (int k = start; k < end; k++)
       {
           if (i < middle && (j >= end || arr[i]<=arr[j]))
           {
               //copy from the first subarray
               temp[k] = arr[i];
               i++;
           }
           else
           {
               //copy from the second subarray
               temp[k] = arr[j];
               j++;
           }
       }
   }

   static void CopyArray(int[] temp, int[] arr)
   {
       for (int i = 0; i < temp.Length; i++)
       {
           arr[i] = temp[i];
       }
   }
}