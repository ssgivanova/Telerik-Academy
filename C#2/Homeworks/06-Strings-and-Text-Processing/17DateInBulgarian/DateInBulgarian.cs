/*
Write a program that reads a date and time given in the format:  
day.month.year hour:minute:second  
and prints the date and time after  6  hours and  30  minutes (in the same format) along with the day
of week in Bulgarian. 
 * */

using System;
using System.Globalization;
using System.Threading;

class DateInBulgarian
{
   static void Main()
   {
       CultureInfo cultureBG = new CultureInfo("bg-BG");
       Console.WriteLine("Enter date in the format : dd.MM.yyyy hh:mm:ss ");
       DateTime dt = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy hh:mm:ss", cultureBG);

       double minutes = 6 * 60 + 30;
       DateTime after = dt.AddMinutes(minutes);
       //DateTime after = dt.AddHours(6).AddMinutes(30);

       Console.WriteLine("{0:dd.MM.yyyy hh:mm:ss dddd}", after);
   }
}
