using System;
/*
We are given an array of integers and a number  S . 
Write a program to find if there exists a subset of the elements of the array that has a sum  S .

input array : 2, 1, 2, 4, 3, 5, 2, 6
S           : 14
result      : yes */

class SubsetWithSumS
{
  static void Main()
  {
      int n = int.Parse(Console.ReadLine());
      int sum = int.Parse(Console.ReadLine());

      int[] arr = new int[n];
      for (int i = 0; i < n; i++)
      {
          arr[i] = int.Parse(Console.ReadLine());
      }
  }
}
