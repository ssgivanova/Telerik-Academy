using System;
using System.Threading;
using System.Globalization;


class CoffeeMachine
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            decimal amount = decimal.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());

            decimal totalMoney = n1 * 0.05m + n2 * 0.10m + n3 * 0.20m + n4 * 0.50m + n5 * 1.00m;
            decimal change = amount - price;
            decimal left = totalMoney - change;

            if (amount < price)
            {
                Console.WriteLine("More {0:f2}", price - amount);
            }
            else //amount >= price
            {
                if (totalMoney >= change)
                {
                    Console.WriteLine("Yes {0:f2}",left);
                }
                else // (totalMoney < change)
                {
                    Console.WriteLine("No {0:f2}",Math.Abs(left));
                }
            }
        }
    }
