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

      bool hasSum = false;

      int[] arr = new int[n];
      for (int i = 0; i < n; i++)
      {
          arr[i] = int.Parse(Console.ReadLine());
      }
      int sum = int.Parse(Console.ReadLine());

      hasSum = isSubsetSum(arr, n, sum);
      Console.WriteLine(hasSum);

      //SECOND SOLUTION
      //2^n  all combinations, -1 to not enclude the empty subset
      int combinations = (int)Math.Pow(2, n) - 1;

      for (int i = 1; i <= combinations; i++)
      {
          int currentSum = 0;
          for (int j = 0; j < n; j++)
          {
              int bit = ((1 << j) & i) >> j;
              if (bit == 1)
              {
                  currentSum += arr[j];
              }
              
              if (currentSum == sum)
              {
                  hasSum = true;
                  break;
              }
          }
      }
      Console.WriteLine(hasSum);

  }
    static bool isSubsetSum(int[] arr,int n, int sum)
    {
        //base cases
        if (n == 0 && sum > 0)
        {
            return false;
        }
        if (sum == 0)
        {
            return true;
        }

        //if last element > sum -> ignore it
        if (arr[n - 1] > sum)
        {
            return isSubsetSum(arr, n - 1, sum);
        }

        //in the other cases we make 2 steps
        //check the arrays excluding the last element - isSubsetSum(arr, n-1,sum)
        //check the arrays including the last element - isSubsetSum(arr, n-1,sum-arr[n-1])
        //if some of the 2 conditions are true -> WE HAVE THE SUM
        return isSubsetSum(arr, n - 1, sum) || isSubsetSum(arr, n - 1, sum - arr[n - 1]);
    }
}
