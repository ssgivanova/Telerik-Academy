using System;
/*
Write a program that reads two integer numbers N and K and an array of N elements from the console. 
Find the maximal sum of K elements in the array.

Input
•On the first line you will receive the number N
•On the second line you will receive the number K
•On the next N lines the numbers of the array will be given

Output
•Print the maximal sum of K elements in the array

Constraints
•1 <= N <= 1024
•1 <= K <= N
•Time limit: 0.1s
•Memory limit: 16MB
*/
class MaximalKSum
{
   static void Main()
   {
       int n = int.Parse(Console.ReadLine());
       int k = int.Parse(Console.ReadLine());

       
       int maxKSum = 0;

       int[] arr = new int[n];
       for (int i = 0; i < n; i++)
       {
           arr[i] = int.Parse(Console.ReadLine());
       }

       //sort the array, so the biggest elements are in the end -> 
       //then find their sum - it's the maximal sum
       Array.Sort(arr);
       
       for (int i = arr.Length-1; i >= n-k; i--)
       {
           maxKSum += arr[i]; 
       }
       Console.WriteLine(maxKSum);
   }
}
