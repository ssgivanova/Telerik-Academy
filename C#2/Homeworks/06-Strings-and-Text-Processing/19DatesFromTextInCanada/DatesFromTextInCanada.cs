/*
Write a program that extracts from a given text all dates that match the format  DD.MM.YYYY
Display them in the standard date format for Canada.
 */


using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class DatesFromTextInCanada
{
   static void Main()
    {
        //string text = Console.ReadLine();
        string text = "Today is 22.05.2016. Tomorrow will be 23.05.2016 and the next day will be 24.05.2016";

        CultureInfo cultureCA = new CultureInfo("fr-CA");
        List<DateTime> dates = new List<DateTime>();
        
       string[] words = text.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
       string[] cleanWords = new string[words.Length];


       //if the date is in the end of sentence and has '.' - remove it
       for (int i = 0; i < words.Length; i++)
       {
          string currentWord = words[i];
          if (currentWord[currentWord.Length - 1] == '.')
          {
              string newCurrentWord = currentWord.Substring(0, currentWord.Length - 1);
              cleanWords[i] = newCurrentWord;
          }
          else
          {
              cleanWords[i] = currentWord;
          }
       }

       //search for dates in cleanwords and add them to list of dates
        for (int i = 0; i < cleanWords.Length; i++)
        {
            DateTime currentDate;
            if(DateTime.TryParse(cleanWords[i],out currentDate))
            {
                dates.Add(currentDate);
            }
            else
            {
                continue;
            }
        }

       //print all dates in canadian datetime formatting
        Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-CA");

        foreach (DateTime date in dates)
        {
            Console.WriteLine(date.ToShortDateString());
        }


       //SECOND SOLUTION - REGULAR EXPRESSIONS
     
        foreach (var match in Regex.Matches(text, @"[\d]{1,2}.[\d]{1,2}.[\d]{4}"))
        {
            try
            {
                DateTime check = DateTime.ParseExact(match.ToString(), "d.MM.yyyy", cultureCA);
                Console.WriteLine(check.ToShortDateString());
            }
            catch (FormatException)
            {
                continue;
            }
        }

    }
}
