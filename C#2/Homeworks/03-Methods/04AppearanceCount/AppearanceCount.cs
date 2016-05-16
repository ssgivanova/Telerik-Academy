using System;
/*
Write a method that counts how many times given number appears in a given array. 
Write a test program to check if the method is working correctly.

Input
•On the first line you will receive a number N - the size of the array
•On the second line you will receive N numbers separated by spaces - the numbers in the array
•On the third line you will receive a number  

test
8
28 6 21 6 -7856 73 73 -56
73

Output
•Print how many times the number X appears in the array

Constraints
•1 <= N <= 1024
•Time limit: 0.1s
 
 */

class AppearanceCount
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

        int x = int.Parse(Console.ReadLine());
        int count = GetCountNumberInArray(arr, x);

        Console.WriteLine(count);
    }

    static int GetCountNumberInArray(int[] arr, int number)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {
                count++;
            }
        }
        return count;
    }
}