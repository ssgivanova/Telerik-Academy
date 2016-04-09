using System;

//Write a program that reads a number N and prints on the console the first N members of the 
//Fibonacci sequence (at a single line, separated by comma and space - ", ") :  
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … .

//Input
//•On the only line you will receive the number N

//Output
//•On the only line you should print the first N numbers of the sequence, separated by ", " (comma and space)

//Constraints
//•1 <= N <= 50 
//•N will always be a valid positive integer number


class FibonnacciNumbers

{
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int n1 = 0;
            int n2 = 1;

            if (n == 1)
            {
                Console.Write("{0}", n1);
            }
            else
            {
                Console.Write("{0}, {1}", n1, n2);
                for (int i = 1; i < n - 1; i++)
                {
                    int n3 = n1 + n2;
                    n1 = n2;
                    n2 = n3;
                    Console.Write(", {0}", n3);
                 }
              }
        }
}
