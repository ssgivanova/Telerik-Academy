using System;
class SumEvenDivisor
{
     static void Main()
     {
         int a = int.Parse(Console.ReadLine());
         int b = int.Parse(Console.ReadLine());

         int max = Math.Max(a, b);
         int min = Math.Min(a, b);

         int divisor = 1;
         int sumDivisor = 0;

         for (int j = min; j <= max; j++)
         {
             int n = j;
             //Console.WriteLine(i);
             //find all divisors of number

             for (int i = 1; i <= n; i++)
             {
                 if (n % i == 0)
                 {
                     divisor = i;
                     //Console.WriteLine(divisor);
                     if (divisor % 2 == 0)
                     {
                         sumDivisor += divisor;
                     }
                 }
                 //Console.WriteLine(sumDivisor);
             }
         }
         Console.WriteLine(sumDivisor);
     }
}
