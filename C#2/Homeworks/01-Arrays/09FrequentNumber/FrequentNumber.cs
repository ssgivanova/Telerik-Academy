using System;
/*
 Write a program that finds the most frequent number in an array of N elements.

Input
•On the first line you will receive the number N
•On the next N lines the numbers of the array will be given

Output
•Print the most frequent number and how many time it is repeated ◦Output should be  REPEATING_NUMBER (REPEATED_TIMES times) 


Constraints
•1 <= N <= 1024
•0 <= each number in the array <= 10000
•There will be only one most frequent number
•Time limit: 0.1s
•Memory limit: 16MB

 * */
class FrequentNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int count = 1;
        int maxCount = 1;
        int maxNumber = 0;

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        //1.sort array
        //2. find the maximal sequence of equal numbers -> maxCount

        Array.Sort(arr);
              
        for (int i = 0; i < n-1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                count++;
                if (count > maxCount)
                {
                    maxCount = count;
                    maxNumber = arr[i];
                }
            }
            else
            {
                count = 1;
            }
        }

        //initialize for the case when n=1 -> this number is the most frequent
        if (n == 1)
        {
            maxNumber = arr[0];
            Console.WriteLine("{0} ({1} times)", maxNumber, maxCount);
        }
        else
        {
            if (maxCount == 1)
            {
                //when all the numbers are different,there's no most frequent number
                Console.WriteLine("no most frequent number");
            }
            else
            {
                Console.WriteLine("{0} ({1} times)", maxNumber, maxCount);
            }
        }
    }
}
