using System;
using System.Collections.Generic;
using System.Linq;
/*
 You are given an array of strings. Write a method that sorts the array by the length of its elements 
 (the number of characters composing them).
 */
class SortByStringLength
{
    static void Main()
    {
        //with lambda expressions
        Console.WriteLine("Enter several words separated by space or comma to sort by length :");
        var sortedLengths = Console.ReadLine()
            .Split(new char[] { ' ', '\t', ',', '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
            .OrderBy(x => x.Length).ToList();

        //print lengths of all the distinc words
        sortedLengths = sortedLengths.Distinct().ToList();
        foreach (var l in sortedLengths)
        {
            Console.Write(l + " ");
        }

        //without lambda expressions
        Console.WriteLine("Enter n :");
        int n = int.Parse(Console.ReadLine());
        string[] words = new string[n];

        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();
        }

        SortArrayByElementsLength(words);
        //print sorted words
        foreach (string word in words)
        {
            Console.Write(word + " ");
        }

    }

    public static void SortArrayByElementsLength(string[] array)
    {
        string temp = null;
        int indexer = 0;
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            temp = array[i];
            counter = 0;

            for (int j = i; j < array.Length; j++)
            {
                if (array[j].Length > counter)
                {
                    counter = array[j].Length;
                    indexer = j;
                    temp = array[j];
                }
            }

            array[indexer] = array[i];
            array[i] = temp;
        }

        Array.Reverse(array);

        
    }
}
