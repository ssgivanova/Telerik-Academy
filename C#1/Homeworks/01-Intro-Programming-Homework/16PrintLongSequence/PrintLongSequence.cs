//Write a program that prints the first 1000 members of the sequence:  
//2, -3, 4, -5, 6, -7, … 

using System;

    class PrintLongSequence
    {
        static void Main()
        {
            int count = 1000;
            int start = 2;
            for (int i = 0; i < count; i++)
            {
                if (start % 2 == 0)
                {
                    Console.WriteLine(start);
                }
                else
                {
                    Console.WriteLine(start * (-1));
                }
                start++;

            }

        }
    }
