/*
 You are given a text. Write a program that changes the text in all regions surrounded by the tags  
 <upcase>  and  </upcase>  to upper-case.

Input
•On the only line you will receive a string - the text

Output
•Print the changed string on one line

Constraints
•The tags will not be nested.
•String length will be <= 10000
•Time limit: 0.1s
•Memory limit: 16MB

 * */

using System;
using System.Text;
using System.Text.RegularExpressions;
class ParseTags
{
   static void Main()
   {
       string text = Console.ReadLine();
       //string text = "We are living in a <upcase> yellow submarine </upcase>. We don't have <upcase> anything </upcase> else.";

       string startTag ="<upcase>";
       string endTag ="</upcase>";

       //find first occurences
       int startTagIndex = text.IndexOf(startTag);
       int endTagIndex = text.IndexOf(endTag);
       int nextIndexToSearch = 0;

       while (startTagIndex != -1 && endTagIndex != -1)
       {
           //find text to make uppercase
           int upperTextStart = startTagIndex + startTag.Length + 1;
           int upperTextLength = endTagIndex - upperTextStart - 1;

           string textToUp = text.Substring(upperTextStart, upperTextLength);
           string textToInsert = textToUp.ToUpper();

           //replace the upper text
           text = text.Replace(textToUp, textToInsert);

           //remove tags - lenght +1 for the additional space between the 2 tags
           //text = text.Remove(endTagIndex-1, endTag.Length+1);
           //text = text.Remove(startTagIndex, startTag.Length+1);

           text = text.Remove(endTagIndex, endTag.Length);
           text = text.Remove(startTagIndex, startTag.Length);

           //change indexes
           nextIndexToSearch = 0;
           startTagIndex = text.IndexOf(startTag,nextIndexToSearch);
           endTagIndex = text.IndexOf(endTag,nextIndexToSearch);
           
       }

       Console.WriteLine(text);

       //REGULAR EXPRESSIONS SOLUTIONS

       string text2 = "We are living in a <upcase> yellow submarine </upcase>. We don't have <upcase> anything </upcase> else.";
       string[] sentences = text2.Split('.');
       string res = string.Empty;

       for (int i = 0; i < sentences.Length; i++)
       {
           res = sentences[i].Trim().Replace("<upcase>", string.Empty);
           res = res.Replace("</upcase>", string.Empty);
           //Console.WriteLine(res);
       }
           
        
       //string result = Regex.Replace(text, @"<upcase>(.?*)</upcase>");

       
       /*
       private static string TagsToUpper(string text)
        {
            return Regex.Replace(text, @"<upcase>(.*?)</upcase>", delegate(Match match)
            {
                string current = match.ToString().ToUpper();
                return Regex.Replace(current, @"<[^>]*>", String.Empty);
            });
        }
        */ 

   }
}
