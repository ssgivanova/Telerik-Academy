using System;
using System.Threading;
using System.Globalization;

class Money
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());
            int sheets = int.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());

            decimal money = 0m;
            int sheetsInRealm = 400;

            int totalSheets = n * sheets;
            decimal realmsNeeded = (decimal) totalSheets / sheetsInRealm;

            money = realmsNeeded * price;
            Console.WriteLine("{0}", Math.Round(money, 3));
        }
    }