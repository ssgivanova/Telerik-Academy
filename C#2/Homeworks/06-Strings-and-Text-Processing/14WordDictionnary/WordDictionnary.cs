/*
A dictionary is stored as a sequence of text lines containing words and their explanations. 
Write a program that enters a word and translates it by using the dictionary.

Sample tests

.NET      -> platform for applications from Microsoft 
CLR       -> managed execution environment for .NET 
namespace -> hierarchical organization of classes 
 
 * */

using System;
using System.Collections.Generic;
class WordDictionnary
{
    static Dictionary<string, string> dict = new Dictionary<string, string>();

    static void Main()
    {
        //fill and print dicitonnary
        FillDictionnary();


        // Loop over pairs with foreach.
        foreach (KeyValuePair<string, string> pair in dict)
        {
            Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
        }
        //Use var keyword to enumerate dictionary.
        //foreach (var pair in dict)
        //{
        //    Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
        //}
        
        //search for word
        Console.WriteLine("Enter a word");
        string wordKey = Console.ReadLine().ToLower().Trim();
        
        //look for a description by searching by word
        if (dict.ContainsKey(wordKey))
        {
            string value = dict[wordKey];
            Console.WriteLine(value);
        }
        else
        {
            Console.WriteLine("word {0} not found in the dictionnary",wordKey);
        }
    }

    static void FillDictionnary()
    {
        //fill the dictionnary
        //dict.Add(wordKey, description);
        dict.Add(".net", "platform for applications from Microsoft");
        dict.Add("clr", "managed execution environment for .NET");
        dict.Add("namespace", "hierarchical organization of classes");
    }
}
