using System;

/*Write a program that reads an array of integers and removes from it a minimal number of 
 elements in such a way that the remaining array is sorted in increasing order. 
 Print the minimal number of elements that need to be removed in order for the array to become sorted.

Input
•On the first line you will receive the number N
•On the next N lines the numbers of the array will be given

Output
•Print the minimal number of elements that need to be removed

Constraints
•1 <= N <= 1024
•Time limit: 0.1s
•Memory limit: 16MB
*/

class RemoveElementsFromArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        //longest increasing sequence
    }
}
