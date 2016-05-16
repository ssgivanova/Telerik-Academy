using System;
/*
Write a method  GetMax()  with two parameters that returns the larger of two integers. 
Write a program that reads  3  integers from the console and prints the largest of them using the method  GetMax() .

Input
•On the first line you will receive  3  integers separated by spaces

Output
•Print the largest of them

Constraints
•Time limit: 0.1s
•Memory limit: 16MB

 */
class GetLargestNumber
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        int max = GetMax(GetMax(a, b), c);
        Console.WriteLine(max);
    }

    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}
