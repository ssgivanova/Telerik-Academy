namespace RangeExceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Globalization;
    /*
    Define a class  InvalidRangeException<T>  that holds information about an error condition related 
    to invalid range. It should hold error message and a range definition [ start … end ].
    Write a sample application that demonstrates the  InvalidRangeException<int>  
    and  InvalidRangeException<DateTime>  by entering numbers in the range [ 1..100 ] 
    and dates in the range [ 1.1.1980 … 31.12.2013 ].
  */

    class Startup
    {
        static void Main()
        {
            
            int n = 0;
            Console.WriteLine("Enter number in the range [1,100]");
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n < 1 || n > 100)
                {
                    throw new InvalidRangeException<int>(String.Format("Invalid range.Number must be between {0} and {1}",1,100), 1, 100);
                }
            }
            catch(InvalidRangeException<int> ire)
            {
                Console.WriteLine(ire.Message); 
            }
             

            //Datetime [ 1.1.1980 … 31.12.2013 ]
            try
            {
                //DateTime dt = DateTime(2014, 12, 31);
                Console.WriteLine("Enter number in the range [(1980,1,1),(2013,12,31)] in format yyyy,MM,dd");
                DateTime dt = DateTime.ParseExact(Console.ReadLine(), "yyyy,MM,dd", CultureInfo.InvariantCulture);
                if (dt < new DateTime(1980, 1, 1) || dt > new DateTime(2013, 12, 31))
                {
                    throw new InvalidRangeException<DateTime>(String.Format("Invalid range.Number must" +
                    "be between {0} and {1}", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31)),
                    new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
                }
            }
            catch (InvalidRangeException<DateTime> ire)
            {
                Console.WriteLine(ire.Message);
            }
            
        }
    }
}
