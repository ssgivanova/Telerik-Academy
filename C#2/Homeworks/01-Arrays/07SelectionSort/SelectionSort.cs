using System;

/*
 Sorting an array means to arrange its elements in increasing order. 
 Write a program to sort an array. Use the Selection sort algorithm: 
 Find the smallest element, move it at the first position, find the smallest from the rest, 
 move it at the second position, etc.

Input
•On the first line you will receive the number N
•On the next N lines the numbers of the array will be given

Output
•Print the sorted array ◦Each number should be on a new line


Constraints
•1 <= N <= 1024
•Time limit: 0.1s
•Memory limit: 16MB

 */

class SelectionSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        //print array before sorting
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write(arr[i] +" ");
        //}

        //selection sort
        for (int i = 0; i < n-1; i++)
        {
            //set min to the first element of the current iteration
            int min = arr[i];

            for (int j = i+1; j < n; j++)
            {
                if (arr[j] < min)
                {
                    min = arr[j];
                    //swap first element
                    int temp = arr[i];
                    arr[i] = min;
                    arr[j] = temp;
                }
            }
            //Console.WriteLine("min" + min);
        }
        
        //print array after sorting
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
