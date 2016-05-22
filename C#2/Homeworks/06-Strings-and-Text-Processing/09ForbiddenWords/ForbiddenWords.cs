/*
 We are given a string containing a list of forbidden words and a text containing some of these words.
 Write a program that replaces the forbidden words with asterisks.
 * */

using System;
class ForbiddenWords
{
    static void Main()
    {
        string text = Console.ReadLine();
        string forbidden = Console.ReadLine();

        string[] forbiddenWords = forbidden.Split(new char[] {' ', ',', '.'}, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in forbiddenWords)
        {
            text = text.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(text);
    }
}
