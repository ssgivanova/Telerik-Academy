/*
Write a program that reads an integer number and calculates and prints its square root.
•If the number is invalid or negative, print  Invalid number .
•In all cases finally print  Good bye . Use  try-catch-finally  block.

Input
•On the only line you will receive a real number

Output
•Print the square root of the number or  Invalid number  on the first line ◦Use  3  digits of precision

•Print  Good bye  on the second line

Constraints
•Time limit: 0.1s
•Memory limit: 16MB

 * */

using System;
class SquareRoot
{
    static void Main()
    {
        string input =  Console.ReadLine();

        try
        {
            int num = int.Parse(input);
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid number");
            }

            double squareRoot = Math.Sqrt((double)num);
            Console.WriteLine("{0:f3}", squareRoot);
        }
        catch (ArgumentOutOfRangeException aore)
        {
            Console.WriteLine("Invalid number",aore);
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Invalid number", fe);
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
