using System;
/*
Write a method that checks if the element at given position in given array of integers is larger 
than its two neighbours (when such exist). 
Write program that reads an array of numbers and prints how many of them are larger than their neighbours.

Input
•On the first line you will receive the number N - the size of the array
•On the second line you will receive N numbers separated by spaces - the array

test
6
-26 -25 -28 31 2 27
result -> 2
 
Output
•Print how many numbers in the array are larger than their neighbours

Constraints
•1 <= N <= 1024
•Time limit: 0.1s
•Memory limit: 16MB

 * 
 */
class LargerThanNeighbours
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

        //count larger than its neighbours
        int count = CountLargerThanNeighbours(arr);
        Console.WriteLine(count);
    }

    static int CountLargerThanNeighbours(int[] arr)
    {
        int count = 0;
        for (int i = 1; i < arr.Length -1; i++)
        {
            //count only elements with 2 neighbours
            //in the 2 boundaries - we have to exclude element i = 0 and i = n-1 (they have 1 neighbour each)
            if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
            {
                count++;
            }
        }
        #region
        //if we count them also elements with one neighbour
        /*
        for (int i = 0; i < arr.Length; i++)
        {
            if (i > 0 && i < arr.Length - 1)
            {
                //2 neighbours - elements from index [1,n-2]
                if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
                {
                    count++;
                }
            }
            else //1 neighbour 
            {
                if (i == 0)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        count++;
                    }
                }
                else if (i == arr.Length - 1)
                {
                    if (arr[i] > arr[i - 1])
                    {
                        count++;
                    }
                }
            }
        } */
        #endregion
        return count;
    }
}
