using System;
using System.Globalization;
/*
Write a method that calculates the number of workdays between today and a given date, 
passed as parameter. Consider that workdays are all days from Monday to Friday except 
a fixed list of public holidays specified preliminary as array.
 */
class Workdays
{
    static DateTime[] holidays2016 = { new DateTime(2016, 1, 1), 
                                       new DateTime(2016, 3, 3),
                                       new DateTime(2016, 5, 1),
                                       new DateTime(2016, 5, 6),
                                       new DateTime(2016, 5, 24),
                                       new DateTime(2016, 9, 6),
                                       new DateTime(2016, 9, 22),
                                       new DateTime(2016, 12, 24),
                                       new DateTime(2016, 12, 25),
                                       new DateTime(2016, 12, 26)};

   static void Main()
   {
       DateTime today = DateTime.Today;
       Console.WriteLine("Enter a date : (day.month.year)");
       string format = "dd.MM.yyyy";
       DateTime date = DateTime.ParseExact(Console.ReadLine(), format,CultureInfo.InvariantCulture);

       int countAllDaysWithoutWeekends = 0;
       int countWorkingDays = 0;
       int countHolidays = 0;

       DateTime startDate = new DateTime();
       DateTime endDate = new DateTime();

       if (date.CompareTo(today) < 0)
       {
           //the given day is before today
           startDate = date;
           endDate = today;
       }
       else if (date.CompareTo(today) > 0)
       {
           //the given day is after today
           startDate = today;
           endDate = date;
       }
       countHolidays = GetCountHolidaysInPeriod(startDate, endDate);
       countWorkingDays = GetCountWorkingDaysInPeriod(today, date);
       countAllDaysWithoutWeekends = countHolidays + countWorkingDays;

       Console.WriteLine("Days in period : {0} - {1} :",startDate,endDate);
       Console.WriteLine("{0} total days", countAllDaysWithoutWeekends);
       Console.WriteLine("-> {0} holidays", countHolidays);
       Console.WriteLine("-> {0} working days", countWorkingDays);
   }

   static int GetCountWorkingDaysInPeriod(DateTime startDate, DateTime endDate)
   {
       int countWorkingDays = 0;
       bool isHoliday = false;
       for (DateTime currentDate = startDate; currentDate < endDate; currentDate = currentDate.AddDays(1))
           {
               if (!(currentDate.DayOfWeek.Equals(DayOfWeek.Saturday) || currentDate.DayOfWeek.Equals(DayOfWeek.Sunday)))
               {
                   //check if it's official holiday
                   for (int i = 0; i < holidays2016.Length; i++)
			        {
                        if (currentDate.CompareTo(holidays2016[i]) == 0)
                        {
                            isHoliday = true;
                            //Console.WriteLine(holidays2016[i]); //holiday
                            break;
                        }
                        else
                        {
                            isHoliday = false;                            
                        }
			        }
                   if (!isHoliday)
                   {
                       countWorkingDays++;
                   }
               }
               //else
               //{    //weekends
               //    Console.WriteLine("weekend day"); 
               //}
       }
       return countWorkingDays;
   }

   static int GetCountHolidaysInPeriod(DateTime startDate, DateTime endDate)
   {
       int countHolidays = 0;
       bool isHoliday = false;
       for (DateTime currentDate = startDate; currentDate < endDate; currentDate = currentDate.AddDays(1))
       {
           if (!(currentDate.DayOfWeek.Equals(DayOfWeek.Saturday) || currentDate.DayOfWeek.Equals(DayOfWeek.Sunday)))
           {
               //check if it's official holiday
               for (int i = 0; i < holidays2016.Length; i++)
               {
                   if (currentDate.CompareTo(holidays2016[i]) == 0)
                   {
                       isHoliday = true;
                       //Console.WriteLine(holidays2016[i]); //holiday
                       countHolidays++;
                       break;
                   }
                   else
                   {
                       isHoliday = false;
                   }
               }
           }
       }  
       return countHolidays;
   }
    
}
