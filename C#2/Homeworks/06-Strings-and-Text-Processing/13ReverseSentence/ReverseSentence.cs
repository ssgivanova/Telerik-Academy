/*
Write a program that reverses the words in a given sentence.

C# is not C++, not PHP and not Delphi! -> Delphi not and PHP, not C++ not is C#! 
 * */

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class ReverseSentence
{
   static void Main()
   {
       /*
       string text1 = "C#   is not C++, not PHP and not Delphi!  Test 1, 2,3";

       string regex = @"\s+|,\s*|\.\s*|!\s*|$";

       var words = new Stack<string>();

       foreach (var word in Regex.Split(text, regex))
       {
           if (!String.IsNullOrEmpty(word)) words.Push(word);
       }

       foreach (var separator in Regex.Matches(text1, regex))
       {
           //Console.Write(words.Pop() + separator);
           Console.WriteLine(separator);
       }
       */
       

       //string text = Console.ReadLine();
       string text = "C# is not C++, not PHP and not Delphi!";
       StringBuilder reversed = new StringBuilder();

       string regex = @"\s+|,\s*|\.\s*|!\s*|$";

       //split text by punctuation - > to obtain only the words
       string[] words = text.Split(new char[] {' ',',','!' }, StringSplitOptions.RemoveEmptyEntries);
       //string[] words = Regex.Split(text, regex);

       //split text by words - > to obtain only the punctuation symbols
       string[] punctuation = new string[] { " ", " ", " ", ", ", " ", " ", " ", " ","!"};

       //string[] punctuation1 = Regex.Split(text, @"\w+");
       //var punctuation1 = Regex.Matches(text, regex);

       //for test
       //int k = 0;
       //foreach (var item in punctuation)
       //{
       //    Console.WriteLine("{0} - {1}",k,item);
       //    k++;
       //}
       
       Stack<string> wordsStack = new Stack<string>();

       //words
       foreach (string word in words)
       {
           wordsStack.Push(word);
       }

       //punctuation - doesn't work - incorrect number of elements
       //foreach (Match symbol in punctuation1)
       //{
       //    while (punctuation1.Count >= 1)
       //    {
       //        reversed.Append(wordsStack.Pop() + symbol);
       //    }
       //}
       //Console.WriteLine(reversed.ToString());

       foreach (string symbol in punctuation)
       {
           if (symbol != string.Empty)
           {
               reversed.Append(wordsStack.Pop() + symbol);
           }
       }
       Console.WriteLine(reversed.ToString());
   }
}
