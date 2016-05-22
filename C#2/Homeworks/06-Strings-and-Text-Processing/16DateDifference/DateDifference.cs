/*
Write a program that reads two dates in the format:  day.month.year  and calculates the number of days 
between them.

Example:
Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days


 */

using System;
using System.Globalization;
using System.Threading;
class DateDifference
{
   static void Main()
   {
       DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
       DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);

       //compare the 2 dates
       DateTime minDate = new DateTime();
       DateTime maxDate = new DateTime();
       if (date1.CompareTo(date2) < 0)
       {
           minDate = date1;
           maxDate = date2;
       }
       else if (date1.CompareTo(date2) > 0)
       {
           minDate = date2;
           maxDate = date1;
       }

       int countDays = (int)((maxDate - minDate).TotalDays);
       Console.WriteLine(countDays);

       double days = maxDate.Subtract(minDate).TotalDays;
       Console.WriteLine(days);

       //DateTime xmas = new DateTime(2009, 12, 25);
       //double daysUntilChristmas = xmas.Subtract(DateTime.Today).TotalDays;
       //Console.WriteLine(daysUntilChristmas);

       
   }
}
