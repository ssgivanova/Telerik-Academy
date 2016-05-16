using System;
using System.Numerics;
/*
Write a method that multiplies a number represented as an array of digits by a given integer number. 
Write a program to calculate  N! .

Input
•On the first line you will receive the number N

Output
•Print  N! 

Constraints
•0 <= N <= 100
•Time limit: 0.1s
•Memory limit: 16MB
 * 
 test 5 -> 120
 
 * */
class NFactoriel
{
   static void Main()
   {
       int n = int.Parse(Console.ReadLine());
       int[] arr = new int[n];

       for (int i = 0; i < arr.Length; i++)
       {
           arr[i] = i+1;
       }

       //PrintArray(arr);
       BigInteger fact = CalculateFactoriel(arr);
       Console.WriteLine(fact);
       
   }

    //calculate factoriel by presenting the digits as successive elements of an array 
   static BigInteger CalculateFactoriel(int[] arr)
   {
       BigInteger fact = 1;
       for (int i = 0; i < arr.Length; i++)
       {
           fact *= arr[i];
       }

       return fact;
   }

   static void PrintArray(int[] arr)
   {
       foreach (int item in arr)
       {
           Console.Write(item + " ");
       }
   }
}