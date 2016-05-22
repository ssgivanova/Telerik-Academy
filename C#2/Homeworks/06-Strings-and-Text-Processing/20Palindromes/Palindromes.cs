/*
Write a program that extracts from a given text all palindromes, e.g.  ABBA ,  lamal ,  exe . 
 */

using System;
using System.Text;

class Palindromes
{
   static void Main()
   {
       string text = "Lorem ipsum dolor sit amet, sos consectetur  ABBA adipiscing elit. Integer lamal nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet. Duis exe sagittis ipsum. Praesent mauris. Fusce nec tellus sed augue semper porta. Mauris massa. Vestibulum lacinia arcu eget nulla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.";
       string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

       StringBuilder sb = new StringBuilder();

       for (int i = 0; i < words.Length; i++)
       {
           string currentWord = words[i];
           if (IsPalindrom(currentWord))
           {
               sb.Append(currentWord);
               sb.Append(" ");
           }
       }
       string result = sb.ToString();
       if (result.Length != 0)
       {
           Console.WriteLine(result);
       }
       else
       {
           Console.WriteLine("No palindroms found");
       }
       

   }

   static bool IsPalindrom(string str)
   {
       bool isPalindrom = true;
       for (int i = 0; i < str.Length/2; i++)
       {
           if (str[i] != str[str.Length - i - 1])
           {
               isPalindrom = false;
               break;
           }
       }
       return isPalindrom;
   }
}
