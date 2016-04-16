using System;
using System.Threading;
using System.Globalization;

class Printing
 {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());
            int sheets = int.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());

            decimal money = 0m;
            int sheetsInRealm = 500;

            int totalSheets = n * sheets;

            money = ((decimal)totalSheets / sheetsInRealm) * price;

            Console.WriteLine("{0:f2}", Math.Round(money,2));
        }
}
