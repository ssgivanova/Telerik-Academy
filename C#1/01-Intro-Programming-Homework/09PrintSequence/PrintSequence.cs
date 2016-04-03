//Write a program that prints the first 10 members of the sequence:
//2, -3, 4, -5, 6, -7, ... 
using System;

class PrintSequence
{
    static void Main()
    {
        int count = 1;
        int n = 2;
        while (count <= 10)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(n * (-1));
            }
            n++;
            count++;
        }
    }
}
