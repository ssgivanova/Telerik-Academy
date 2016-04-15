using System;
using System.Numerics;

//Write a program that calculates N! / K! for given N and K.
//•Use only one loop.

//Input
//•On the first line, there will be only one number - N
//•On the second line, there will be only one number - K

//Output
//•Output a single line, consisting of the result from the calculation described above.

//Constraints
//•1 < K < N < 100 ◦Hint: overflow is possible

//•N and K will always be valid integer numbers


class CalculateAgain
{
    static void Main()
     {
         int n = int.Parse(Console.ReadLine());
         int k = int.Parse(Console.ReadLine());

        //n>k => n!/k! for n=5, k=2 => 1.2.3.4.5/1.2 => 3.4.5 (n-k)!

         BigInteger factoriel = 1;
         for (int i = n; i >= k + 1; i--)
         {
             factoriel *=  i;
         }
         Console.WriteLine(factoriel);
     }
}
