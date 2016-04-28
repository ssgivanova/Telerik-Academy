using System;
using System.Threading;
using System.Globalization;

class AmericanPie
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            ulong f = (ulong)(a * d + b * c);
            ulong g = (ulong)(b * d);
            decimal total = (decimal)f / g;

            if (total >= 1)
            {
                Console.WriteLine(f / g);
            }
            else
            {
                Console.WriteLine("{0:f20}",total);
            }
            Console.WriteLine("{0}/{1}",f,g);
        }
    }
