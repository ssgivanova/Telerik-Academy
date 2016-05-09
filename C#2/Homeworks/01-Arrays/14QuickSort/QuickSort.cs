using System;
/*
Write a program that sorts an array of integers using the Quick sort algorithm.

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
class QuickSort
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
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.Write(arr[i] + " ");
        //}

        //quick sort
        QuickSorting(arr, 0, arr.Length-1);

        //print array after sorting
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    static void QuickSorting(int[] arr, int start, int end)
    {
        //if there is only one element in the array the sorting stops
        if (start>=end)//(end - start <= 1)
        {
            return;
        }

        //first partitioning - reorder the array, so all elements smaller than the pivot become before it
        //and the elements bigger than the pivot go after it
        int i = start;
        int j = end;
        int pivot = arr[(start + end) / 2];
        
        while (i <= j)
        {
            while (arr[i] < pivot)
            {
                i++;
            }
            while (arr[j] > pivot)
            {
                j--;
            }
            if (i <= j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                //swap(arr, arr[i], arr[j]);
                i++;
                j--;
            }
        }
        //partitioning of the subarrays with elements smaller than the pivots and greater than the pivot
        //QuickSorting(arr, start, pivot);
        //QuickSorting(arr, pivot + 1, end);

        // Recursive calls
        if (start < j)
        {
            QuickSorting(arr, start, j);
        }
        if (i < end)
        {
            QuickSorting(arr, i, end);
        }
        
    }
    static void swap(int[] arr, int index1, int index2)
    {
        int temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
    }
}
