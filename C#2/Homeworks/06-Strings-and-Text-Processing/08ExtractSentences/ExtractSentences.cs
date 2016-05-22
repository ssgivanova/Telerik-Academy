/*
 *Write a program that extracts from a given text all sentences containing given word.

Input
•On the first line you will receive a string - the word
•On the second line you will receive a string - the text

Output
•Print only the sentences containing the word on a single line

Constraints
•Sentences are separated by  .  and the words – by non-letter symbols
•Time limit: 0.1s
•Memory limit: 16MB
*/
 

using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;

class ExtractSentences
{
    static void Main()
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();

        /*

        string searchFor = " " + pattern + " ";
        
        //split text in sentences
        string[] sentences = text.Split(new char[] { '.', '!', '?', ';', ':', '-', '\n', '\r','@','\\','\t'}, StringSplitOptions.RemoveEmptyEntries);
        
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < sentences.Length; i++)
        {
            string currentSentence = sentences[i].ToLower();
            int indexPattern = currentSentence.IndexOf(searchFor.ToLower());
            while(indexPattern != -1)
            {
                sb.Append(sentences[i].Trim());
                sb.Append(". ");

                indexPattern = currentSentence.IndexOf(searchFor, indexPattern + searchFor.Length);
            }
        }
        string result = sb.ToString();
        if (result.Length == 0)
        {
            Console.WriteLine("No matches found");
        }
        else
        {
            Console.WriteLine(result);
        }
        */

        
        
        //solution with regular expressions
        List<string> matches = GetMatches(text, pattern);

        if (matches.Count == 0)
        {
            Console.WriteLine("No matches found");
        }
        else
        {
            foreach (var match in matches)
            {
                Console.Write(match +". ");
            }
        }

        //foreach (Match sentence in Regex.Matches(text, @"\s*([^\.]*\b" + pattern + @"\b.*?\.)"))
        //{
        //    Console.WriteLine(sentence.Groups[1]);
        //}
            

        
        


    }

    private static List<string> GetMatches(string text, string pattern)
    {
        string[] sentences = text.Split(new char[] { '.', '!', '?', ';', ':', '-', '\n', '\r', '@', '\\', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> matches = new List<string>();

        foreach (var sentence in sentences)
        {
            //0/100 timeout
            //Match matchWord = Regex.Match(sentence, @"\s*([^\.]*\b" + pattern + @"\b.*?\.)", RegexOptions.IgnoreCase);
            Match matchWord = Regex.Match(sentence, @"\b" + pattern + @"\b", RegexOptions.IgnoreCase);

            if (matchWord.Success)
            {
                matches.Add(sentence.Trim());
            }
        }
        return matches;
    }

}
