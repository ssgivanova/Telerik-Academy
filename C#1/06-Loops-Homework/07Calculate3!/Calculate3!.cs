using System;
using System.Numerics;

//In combinatorics, the number of ways to choose N different members out of a group of N different 
//elements (also known as the number of combinations) is calculated by the following formula: N! / (K! * (N - K)!) 
//formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
//Your task is to write a program that calculates  N! / (K! * (N - K)!)  for given N and K. 
//•Try to use only two loops.

//Input
//•On the first line, there will be only one number - N
//•On the second line, there will also be only one number - K

//Output
//•On the only output line, write the result of the calculation for the provided N and K

//Constraints
//•1 < K < N < 100 

class Calculate3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger cominations = 0;
        BigInteger fact1 = 1;
        BigInteger fact2 = 1;

        for (int i = n; i >= k+1; i--)
        {
            fact1 *= i;
        }
        for (int i = n-k; i > 0; i--)
        {
            fact2 *= i;
        }
        cominations = fact1 / fact2;
        Console.WriteLine(cominations);

    }
}
