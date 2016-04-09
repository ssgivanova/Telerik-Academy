using System;

//Write a program that reads 5 integer numbers from the console and prints their sum.

//Input
//You will receive 5 numbers on five separate lines.

//Output
//Your output should consist only of a single line - the sum of the 5 numbers.

//Constraints
//•All 5 numbers will always be valid integer numbers between -1000 and 1000, inclusive



class Sum5Numbers
    {
        static void Main(string[] args)
        {
            int n = 5;
            int sum = 0;
            
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
