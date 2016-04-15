using System;
using System.Numerics;


//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//C = (2n)!/((n+1)n!) = P (n+k)/k for k = 2 : n

//•Write a program to calculate the Nth Catalan number by given N

//Input
//•On the only line, you will receive the number N

//Output
//•Output a single number - the Nth Catalan number

//Constraints
//•N will always be a valid integer number in the range  [0, 100]  


class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger product = 1;

        if (n >= 0 && n <= 100)
        {
            if (n > 2)
            {
                //for k = 2,N -> product of (n+k)/k
                BigInteger nomenator = 1;
                BigInteger denomenator = 1;
                for (int k = 2; k <= n; k++)
                {
                    nomenator *= (n + k);
                    denomenator *= k;
                    //Console.WriteLine("{0}/{1}",nomenator,denomenator);
                    product = nomenator / denomenator;
                }
            }
            Console.WriteLine(product); 
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }
}
