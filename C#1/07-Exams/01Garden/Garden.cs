using System;
using System.Threading;
using System.Globalization;

class Garden
{
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int tomatoSeedAmount = int.Parse(Console.ReadLine());
            int tomatoArea = int.Parse(Console.ReadLine()); 
            int cucumberSeedAmount = int.Parse(Console.ReadLine());
            int cucumberArea = int.Parse(Console.ReadLine());
            int potatoSeedAmount = int.Parse(Console.ReadLine());
            int potatoArea = int.Parse(Console.ReadLine());
            int carotSeedAmount = int.Parse(Console.ReadLine());
            int carotArea = int.Parse(Console.ReadLine());
            int cabaggeSeedAmount = int.Parse(Console.ReadLine());
            int cabaggeArea = int.Parse(Console.ReadLine());
            int beansSeedAmount = int.Parse(Console.ReadLine());

            int totalArea = 250;
            decimal totalCost = 0.5m * tomatoSeedAmount + 0.4m * cucumberSeedAmount + 0.25m * potatoSeedAmount
                + 0.6m * carotSeedAmount + 0.3m * cabaggeSeedAmount + 0.4m * beansSeedAmount;
            int othersArea = tomatoArea + cucumberArea + potatoArea + carotArea + cabaggeArea;

            Console.WriteLine("Total costs: {0:f2}",totalCost);

            if (othersArea > totalArea)
            {
                Console.WriteLine("Insufficient area");
            }
            else
            {
                int beansArea = totalArea - othersArea;
                if (beansArea <= 0)
                {
                    Console.WriteLine("No area for beans");
                }
                else
                {
                    Console.WriteLine("Beans area: {0}", beansArea);
                }
            }
        }
}
