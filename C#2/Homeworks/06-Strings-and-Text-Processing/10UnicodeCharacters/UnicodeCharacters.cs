using System;
using System.Text;

/*
Write a program that converts a string to a sequence of C# Unicode character literals.

Input
•On the only input line you will receive a string

Output
•Print the string in C# Unicode character literals on a single line

Constraints
•Time limit: 0.1s
•Memory limit: 16MB

Hi! -> \u0048\u0069\u0021 
 */

class UnicodeCharacters
{
    static void Main()
    {
        string text = Console.ReadLine();
        char[] symbols = text.ToCharArray();

        for (int i = 0; i < symbols.Length; i++)
        {
            Console.Write("\\u{0:X4}", (int)symbols[i]);
        }

    }
}
