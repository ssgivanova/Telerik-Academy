using System;

//Write a program that reads from the console a positive integer number N and prints a matrix like in 
//the examples below. Use two nested loops.
//•Challenge: achieve the same effect without nested loops
//3

//1 2 3
//2 3 4
//3 4 5

//Input
//•The input will always consist of a single line, which contains the number N

//Output
//•See the examples.

//Constraints
//•1 <= N <= 20
//•N will always be a valid integer number


class MatrixOfNumbers
{
   static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 1 && n <= 20)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j <= n+i; j++)
                {
                    Console.Write(j+" "); 
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }
}
