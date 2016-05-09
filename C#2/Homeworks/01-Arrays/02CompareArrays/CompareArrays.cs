using System;

/*
Write a program that reads two  integer  arrays of size N from the console and compares them 
element by element.

Input
•On the first line you will receive the number N
•On the next N lines the numbers of the first array will be given
•On the next N lines the numbers of the second array will be given

Output
•Print  Equal  if the two arrays are the same and  Not equal  if they are not

Constraints
•1 <= N <= 20
•N will always be a valid integer number
•Time limit: 0.1s
•Memory limit: 16MB
*/ 
 

class CompareArrays
{
     static void Main()
     {
         int n = int.Parse(Console.ReadLine());

         while (n < 1 || n > 20)
         {
             Console.WriteLine("enter n : [1,20] ");
             n = int.Parse(Console.ReadLine());
         }

         int[] arr1 = new int[n];
         int[] arr2 = new int[n];
         bool isEqual = true;

         //arr1 elements 
         for (int i = 0; i < n; i++)
         {
             arr1[i] = int.Parse(Console.ReadLine());
         }

         //arr2 elements 
         for (int i = 0; i < n; i++)
         {
             arr2[i] = int.Parse(Console.ReadLine());
         }

         //compare arrays
         for (int i = 0; i < n; i++)
         {
             if (arr1[i] != arr2[i])
             {
                 isEqual = false;
                 break;
             }
         }
         if (isEqual)
         {
             Console.WriteLine("Equal");
         }
         else
         {
             Console.WriteLine("Not equal");
         }

     }
 }
