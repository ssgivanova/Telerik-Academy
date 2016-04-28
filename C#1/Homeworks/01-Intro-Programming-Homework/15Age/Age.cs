using System;
using System.Globalization;

    class Age
    {
        static void Main()
        {
            int howOldNow = 0;
            int howOld10YearsLater = 0;
            
            String format = "MM.dd.yyyy";

            DateTime birthdate;
            DateTime now = DateTime.Now;
            
            try
            {
                birthdate = DateTime.ParseExact(Console.ReadLine(), format,
                    CultureInfo.InvariantCulture);

                //Console.WriteLine(birthdate.ToString(format));
                howOldNow = (int)((now.Subtract(birthdate).TotalDays) / 365);
                howOld10YearsLater = howOldNow + 10;

                Console.WriteLine(howOldNow);
                Console.WriteLine(howOld10YearsLater);
            }
            catch (FormatException)
            {
                Console.WriteLine("unable to parse");
            }

            //2nd solution 
            Console.WriteLine("*******************************************");
            Console.WriteLine("What year are you born in? (dd.mm.yyyy)");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            int mybirthYear = birth.Year;


            DateTime timeNow = DateTime.Now;
            int currentYear = timeNow.Year;
            int currentAge;

            //birthday has passed
            if (timeNow.Month > birth.Month)
            {
                currentAge = currentYear - mybirthYear;
            }
            else
            {
                if (timeNow.Month == birth.Year && timeNow.Day >= birth.Day)
                {
                    currentAge = currentYear - mybirthYear;
                }
                else
                {
                    currentAge = currentYear - mybirthYear - 1;
                }
            }

            Console.WriteLine("Now you are " + currentAge);

            int ageAfter10 = currentAge + 10;
            Console.WriteLine("Your age after 10 years will be " + ageAfter10);


        }
    }
