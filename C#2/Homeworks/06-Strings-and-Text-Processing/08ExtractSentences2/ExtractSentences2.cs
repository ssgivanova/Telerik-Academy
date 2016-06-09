using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ExtractSentences2
{
    static void Main()
    {
        //100/100 bgcoder
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();

        //split text by sentences
        string[] sentences = text.Split(new char[] { '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);

        char[] separatorsSentence = GetSeparators(text);

        for (int i = 0; i < sentences.Length; i++)
        {
            string currentSentence = sentences[i].Trim();
            //string currentSentence = sentences[i].ToLower().Trim();
            //Console.WriteLine(currentSentence.Trim());

            //split sentence by words - by non letter symbols
            //char[] separatorsSentence = GetSeparators(currentSentence);
            string[] words = currentSentence.Split(separatorsSentence, StringSplitOptions.RemoveEmptyEntries);
            
            //search for the pattern in each word
            for (int j = 0; j < words.Length; j++)
            {
                string word = words[j];
                //Match matchWord = Regex.Match(word, @"\b" + pattern.ToLower() + @"\b");
                
                //if (matchWord.Success)
                //{
                //    sb.Append(sentences[i].Trim());
                //    sb.Append(". ");
                //    break;
                //}
                if (word.Equals(pattern)) //(word.Equals(pattern.ToLower()))
                {
                    Console.Write(sentences[i].Trim() +". ");
                    break;
                }
            }
        }
        
    }

    static char[] GetSeparators(string str)
    {
        List<char> separators = new List<char>();
        for (int i = 0; i < str.Length; i++)
        {
            if(!Char.IsLetter(str[i]))
            {
                separators.Add(str[i]);
            }
        }
        return separators.Distinct().ToArray();       
    }
}
