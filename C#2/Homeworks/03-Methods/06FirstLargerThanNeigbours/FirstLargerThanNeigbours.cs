using System;
/*
Write a method that returns the index of the first element in array that is larger than its neighbours,
or  -1 , if there is no such element.

Input
•On the first line you will receive the number N - the size of the array
•On the second line you will receive N numbers sepated by spaces - the array

Output
•Print the index of the first element that is larger than its neighbours or  -1  if none are
  
test
6
-26 -25 -28 31 2 27  
result -> 1 

Constraints
•1 <= N <= 1024
•Time limit: 0.1s
•Memory limit: 16MB

 */
class FirstLargerThanNeigbours
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
        int count = GetInfexOfFirstLargerThanNeighbours(arr);
        Console.WriteLine(count);
    }

    static int GetInfexOfFirstLargerThanNeighbours(int[] arr)
    {
        int index = -1;

        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
            {
                index = i;
                break;
            }
        }
        return index;
    }
}
