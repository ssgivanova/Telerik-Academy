/*

Write a program for extracting all email addresses from given text. 
All sub-strings that match the format  <identifier>@<host>…<domain>  should be recognized as emails. 
 */


using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
   static void Main()
   {
       string text = "Write a program for extracting all email addresses from given text. All sub-strings that match the format  <identifier>@<host>…<domain>  should be recognized as emails - example@example.com,foo@bar.info ";

       string emailPattern = @"\w+@\w+\.\w+";
       //string emailPattern = @"[\w+]+@([\w+]+\.)+[\w+]+";

       foreach (var email in Regex.Matches(text, emailPattern))
       {
           Console.WriteLine(email);
       }
   }
}
