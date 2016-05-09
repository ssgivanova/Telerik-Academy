using System;
/*
Write a program that finds all prime numbers in the range [ 1 ... N ]. 
Use the Sieve of Eratosthenes algorithm. 
The program should print the biggest prime number which is  <= N .

Input
•On the first line you will receive the number N

Output
•Print the biggest prime number which is  <= N 

Constraints
•2 <= N <= 10 000 000
•Time limit: 0.3s
•Memory limit: 64MB

 */
class PrimeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool[] primes = new bool[n+1];
        int maxPrime = 0;

        //create list with all numbers from 2 to n
        for (int i = 2; i < primes.Length; i++)
        {
            primes[i] = true;
        }

        for (int i = 2; i < primes.Length; i++)
        {
            //if primes[i] is not marked as false - then it's prime (=true)
            //check all numbers 2*i + i - if they are not false, they are the primes
            if (primes[i] == true)
            {   
                for (int j = 2*i; j < primes.Length; j=j+i)
                {
                    primes[j] = false;
                }
                maxPrime = i;
            }
        }

        //all primes less or equal to n
        /*
        for (int i = 2; i < primes.Length; i++)
        {
            if (primes[i])
            {
                Console.Write(i + " ");
                maxPrime = i;
            }s
        }
        Console.WriteLine();*/

        Console.WriteLine(maxPrime);
    }
}
