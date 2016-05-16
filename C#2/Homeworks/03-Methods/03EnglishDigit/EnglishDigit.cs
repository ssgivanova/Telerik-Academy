using System;
/*
Write a method that returns the last digit of given integer as an English word. 
Write a program that reads a number and prints the result of the method.

test 42 -> two 

Input
•On the first line you will receive a number

Output
•Print the last digit of the number as an English word
 
 */
class EnglishDigit
{
   static void Main()
   {
       int n = int.Parse(Console.ReadLine());
       int lastDigit = n % 10;
       string word = GetDigitAsEnglishWord(lastDigit);
       Console.WriteLine(word);
   }

   static string GetDigitAsEnglishWord(int digit)
   {
       string englishWord = "";
       switch (digit)
       {
           case 0: englishWord = "zero"; break;
           case 1: englishWord = "one"; break;
           case 2: englishWord = "two"; break;
           case 3: englishWord = "three"; break;
           case 4: englishWord = "four"; break;
           case 5: englishWord = "five"; break;
           case 6: englishWord = "six"; break;
           case 7: englishWord = "seven"; break;
           case 8: englishWord = "eight"; break;
           case 9: englishWord = "nine"; break;
           default: break;
       }
       return englishWord;
   }
}
