/*
Write a program that reverses the words in a given sentence.

C# is not C++, not PHP and not Delphi! -> Delphi not and PHP, not C++ not is C#! 
 * */

using System;
using System.Text.RegularExpressions;
class ReverseSentence
{
   static void Main()
   {
       string text = Console.ReadLine();
       string reversed = "";

       string[] words = text.Split(new char[] {' ',',','!' }, StringSplitOptions.RemoveEmptyEntries);

       string[] punctuation = new string[] { ".", ",", ":", "?", "!" };


       //words
       foreach (string item in words)
       {
           Console.WriteLine(item);
       }

       //punctuation
       Console.WriteLine();
       foreach (string item in punctuation)
       {
           Console.WriteLine(item);
       }
       

       /*
       int commaPosition = 0;

       //count comma position
       foreach (string item in words)
       {
           //Console.WriteLine(item);           
           //if (item == string.Empty)
           //{
           //    break;
           //}
           //commaPosition++;
       }
       Console.WriteLine(commaPosition);

       int reversedCommaPosition = 0;
       for (int i = words.Length-2;  i >=0;  i--)
       {
           reversed += words[i];
           reversedCommaPosition++;
           if (reversedCommaPosition == commaPosition)
           {
               reversed += ",";
           }
           if (i > 0 && (words[i] != String.Empty))
           {
               reversed += " ";  // no additional space after the last word
           }
           
       }
       reversed += "!";

       Console.WriteLine(reversed);
       */

   }
}
