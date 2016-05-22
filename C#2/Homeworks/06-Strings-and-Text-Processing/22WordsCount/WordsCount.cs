/*
Write a program that reads a string from the console and lists all different words in the string 
along with information how many times each word is found 
 */

using System;
using System.Collections.Generic;

class WordsCount
{
    static void Main()
    {
        string text = Console.ReadLine();
        //string text = "Hello hello how are you today.Today is a very nice day.Let's go for a walk with you.";

        string[] words = text.ToLower().Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordsCount = new Dictionary<string, int>();

        CountWords(words, wordsCount);        
        
        //print the words and counts
        if (wordsCount.Count == 0)
        {
            Console.WriteLine("No words to count");
        }
        else
        {
            foreach (var pair in wordsCount)
            {
                Console.WriteLine("{0} - {1} times", pair.Key, pair.Value);
            }
        }
    }

    static void CountWords(string[] words, Dictionary<string, int> counts)
    {
        for (int i = 0; i < words.Length; i++)
        {
            string currentWord = words[i];
            if (!counts.ContainsKey(currentWord))
            {
                counts.Add(currentWord, 1);
            }
            else
            {
                //update counts
                counts[currentWord]++;
            }
        }
    }
 }
