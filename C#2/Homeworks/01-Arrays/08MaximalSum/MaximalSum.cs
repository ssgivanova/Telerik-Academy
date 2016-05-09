using System;
/*
 Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
•Can you do it with only one loop (with single scan through the elements of the array)?

Input
•On the first line you will receive the number N
•On the next N lines the numbers of the array will be given

Output
•Print the maximal sum of consecutive numbers

Constraints
•1 <= N <= 1024
•Time limit: 0.1s
•Memory limit: 16MB

 */
class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int maxConsecutiveSum = 0;
        bool areAllNegative = true;
        int maxNegative = Int32.MaxValue;

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        //kadane's algorithm 
        //calculate consecutive sum - if sum if negative -> sum = 0
        //maxConsecutiveSum is the max calculated sum
        
        //check if all the numbers are negative    
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0)
            {
                areAllNegative = false;
                break;
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (!areAllNegative)
            {
                //for the case if not all the numbers are negative
                sum = sum + arr[i];
                if (sum < 0)
                {
                    sum = 0;
                }
                if (sum > maxConsecutiveSum)
                {
                    maxConsecutiveSum = sum;
                }
            }
            else
            {
                //for the case that all the numbers are negative, otherwise sum will be 0
                //the sum = max number of them (smallest number)
                //find biggest negative number
                if (arr[i] < maxNegative)
                {
                    maxNegative = arr[i];
                }
                maxConsecutiveSum = maxNegative;
            }
        }
        Console.WriteLine(maxConsecutiveSum);
    }
}
