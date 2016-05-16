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

        int maxSubsequenceCount = 0;
        int[] tempArr = new int[n]; // helper array storing sequence length for each element

        // for each EndPoint access each subsequence in the array  
        for (int end = 0; end < arr.Length; end++)
        {
            maxSubsequenceCount = 0;

            // for each start point then set a StartPoint => 0 to EndPoint                              
            for (int start = 0; start < end; start++)
            {
                // if current StartPoint element is smaller than the at EndPoint they are members of the same sequence
                if (arr[start] <= arr[end] && tempArr[start] >= maxSubsequenceCount)
                // if the length for the element before is larger than the current MaxSequenceLength
                {
                    // max equals the length for the current element
                    maxSubsequenceCount = tempArr[start];
                }
            }

            // Longest existing sequence
            tempArr[end] = maxSubsequenceCount + 1;
        }

        // Find the max length of subsequence amongst all subsequence lengths
        maxSubsequenceCount = 0;
        for (int i = 0; i < n; i++)
        {
            // Length stored in the helper array                      
            if (tempArr[i] > maxSubsequenceCount)
            {
                maxSubsequenceCount = tempArr[i];
            }
        }

        // Output
        Console.WriteLine(n - maxSubsequenceCount);

    }
}
