/*
Write a program that reads a string from the console and prints all different letters 
in the string along with information how many times each letter is found. 
 * */


using System;
using System.Collections.Generic;

class LettersCount
{
   static void Main()
   {
       string text = Console.ReadLine();

       Dictionary<char, int> lettersCounts = new Dictionary<char, int>();
       
       CountLetters(text.ToLower(), lettersCounts);

       //print letters count
       if (lettersCounts.Count == 0)
       {
           Console.WriteLine("No letters to count");
       }
       else
       {
           foreach (var pair in lettersCounts)
           {
               Console.WriteLine("{0} - {1} times", pair.Key, pair.Value);
           }
       }
   }

   private static void CountLetters(string text, Dictionary<char, int> letters)
   {

       foreach (char character in text)
       {
           //count only the letters (to not count digits, spaces and punctuation)
           if (Char.IsLetter(character))
           {
               if (!letters.ContainsKey(character))
               {
                   letters.Add(character, 1);
               }
               else
               {
                   letters[character] += 1;
               }
           }
       }
   }
}
