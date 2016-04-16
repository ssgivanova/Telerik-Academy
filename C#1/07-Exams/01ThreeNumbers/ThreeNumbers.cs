using System;
using System.Threading;
using System.Globalization;

class ThreeNumbers
 {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int min = a;
            int max = a;
            double mean = 0;

            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }

            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }

            //for problem Three numbers - print mean with 2 digits after the decimal point
            mean = Math.Round(((double)(a + b + c) / 3), 2);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine("{0:f2}", mean);

            //for problem ABC - print mean with 3 digits after the decimal point
            //mean = Math.Round(((double)(a + b + c) / 3), 3);
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            //Console.WriteLine("{0:f3}", mean);

        }
}
