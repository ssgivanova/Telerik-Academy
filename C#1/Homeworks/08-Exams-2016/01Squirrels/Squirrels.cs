using System;
using System.Threading;
using System.Globalization;
using System.Numerics;

class Squirrels
{
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int trees = int.Parse(Console.ReadLine());
            int branches = int.Parse(Console.ReadLine());
            int squirels = int.Parse(Console.ReadLine());
            int avgTails = int.Parse(Console.ReadLine());

            //int trees = 100000;
            //int branches = 5000;
            //int squirels = 800;
            //int avgTails = 100;

            long countTails = (long)branches * (long)squirels * (long)avgTails * (long)trees;

            double result = 0;
            BigInteger resultEven = 0;

            //Console.WriteLine(countTails);

            if (countTails % 2 == 0)
            {
                resultEven = (BigInteger)countTails * 376439;
                Console.WriteLine("{0:f3}", resultEven);
            }
            else
            {
                result = countTails / 7.0;
                Console.WriteLine("{0:f3}", result);
            }
        }
}
