using System;

/*
Write a program that finds the index of given element X in a sorted array of N integers by using 
the Binary search algorithm.

Input
•On the first line you will receive the number N
•On the next N lines the numbers of the array will be given
•On the last line you will receive the number X

Output
•Print the index where X is in the array 
◦If there is more than one occurence print the first one
◦If there are no occurences print  -1 

Constraints
•1 <= N <= 1024
•Time limit: 0.1s
•Memory limit: 16MB

 * */

class BinarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int x = int.Parse(Console.ReadLine());
        Array.Sort(arr);

        //iterative solution
        int start = 0;
        int end = n-1;
        int middleIndex = (start + end)/2;
        int index = -1;
        while (start <= end)
        {
            if (x == arr[middleIndex])
            {
                index = middleIndex;
                break;
            }
            else if (x < arr[middleIndex])
            {
                end = middleIndex - 1;
            }
            else
            {
                start = middleIndex + 1;
            }
            //calculate new middle 
            middleIndex = (start + end) / 2;
        }

        if (start > end)
        {
            //element not present
            index = -1;
        }

        //recursive solution
        //int index = BinarySearchMethod(0, n, arr, x);
        Console.WriteLine(index);
    }

    public static int BinarySearchMethod(int start, int end, int[] arr, int value )
    {
        int middleIndex = (start + end) / 2;

        if (start > end)
        {
            return -1;
        }

        if (value == arr[middleIndex])
        {
            return middleIndex;
        }
        else if (value < arr[middleIndex])
        {
            return BinarySearchMethod(0, middleIndex - 1, arr, value);
        }
        else
        {
            return BinarySearchMethod(middleIndex + 1, arr.Length, arr, value);
        }
    }
}
