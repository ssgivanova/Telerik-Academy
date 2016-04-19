using System;
using System.Threading;
using System.Globalization;

class PieceOfCake
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());

            long nominator = a * d + c * b;
            long denominator = b * d;
            decimal result = (decimal)nominator / denominator;

            if (result >= 1)
            {
                //at least 1 total cake
                Console.WriteLine((long)result);
            }
            else
            {
                result = Math.Round(result,22);
                Console.WriteLine("{0:f22}",result);
            }
            Console.WriteLine("{0}/{1}",nominator,denominator);
        }
    }
