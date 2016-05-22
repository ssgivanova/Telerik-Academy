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
class ExtractSentences
{
    static void Main()
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();
        string searchFor = " " + pattern + " ";

        string[] sentences = text.Split('.');
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].IndexOf(searchFor) > 0)
            {
                Console.Write(sentences[i].Trim());
                Console.Write(". ");
            }
        }
        
        //look for solution with regular expressions


    }
}
