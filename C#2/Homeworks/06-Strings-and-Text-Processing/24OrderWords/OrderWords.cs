/*
Write a program that reads a list of words separated by spaces and prints the list 
in an alphabetical order. 
 */


using System;
using System.Linq;

class OrderWords
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.ToLower().Split(new char[]{' ',',','.'},StringSplitOptions.RemoveEmptyEntries);

        //sort 
        Array.Sort(words);

        for (int i = 0; i < words.Length-1; i++)
        {
            //don't print duplicates from first to element before last
            if(words[i] != words[i+1])
            {
                Console.WriteLine(words[i]);
            }
        }
        //print last
        Console.WriteLine(words[words.Length-1]);

        Console.WriteLine();
        
        // SOLUTION WITH LINQ
        var sortedWords = input.ToLower()
                               .Split(new char[]{' ',',','.'},StringSplitOptions.RemoveEmptyEntries)
                               .Distinct()                       
                               .OrderBy(x => x)
                               .ToList();

        foreach (var item in sortedWords)
        {
            Console.WriteLine(item);
        }
    }
}
