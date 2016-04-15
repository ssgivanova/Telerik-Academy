using System;
using System.Numerics;

//Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
//•Your program should work well for very big numbers, e.g. N = 100000.

//Input
//•On the only input line, you will receive a single integer - the number N

//Output
//•Output a single number - the count of trailing zeroes for the N!

//N will always be a valid positive integer number.
//10 2 3628800 
//20 4 2432902008176640000 
//100000 24999 think why 

class Trailing0InFactoriel
{
   static void Main()
   {
       int n = int.Parse(Console.ReadLine());


       /* FRIST SOLUTION - COUNTING TRAILING ZEROS IN FACTORIAL --> FINDING MULTIPLIERS OF 5 IN [1,N] */
       
       // 4617! -> 4617/5 + 4617/25 + 4617/125 + 4617/625 + 4617/3125 
       // 4617! -> 923 + 184 + 36 + 7 + 1 = 1151 trailing zeroes
       
        /* -----ALGORITHM
        * 
        * Take the number that you've been given the factorial of.
        •Divide by 5; if you get a decimal, truncate to a whole number.
        •Divide by 52 = 25; if you get a decimal, truncate to a whole number.
        •Divide by 53 = 125; if you get a decimal, truncate to a whole number.
        •Continue with ever-higher powers of 5, until your division results in a number less than 1. 
        * Once the division is less than 1, stop.
        •Sum all the whole numbers you got in your divisions. This is the number of trailing zeroes
        */

       int division = 0;
       int power = 1;
       int sum = 0;

       do
       {
           division = (int)(n / Math.Pow(5, power));
           power++;
           sum += division;
       }
       while (division >= 1);
       Console.WriteLine(sum);

       /* ANOTHER SOLUTION - COUNTING TRAILING ZEROS IN FACTORIAL --> TOO SLOW */

       /*
       BigInteger factoriel = 1;
       int count =0;
       
       for (int i = 1; i <= n; i++)
       {
           factoriel *= i;
       }
       //Console.WriteLine("n!={0}",factoriel);

       
       int[] factDigits = new int[factoriel.ToString().Length];
       for (int i = 0; i < factDigits.Length; i++)
       {
           factDigits[i] = (int)Char.GetNumericValue(factoriel.ToString()[i]);
       }
              
       count trailing zeros
       for (int i = factDigits.Length-1; i >= 0; i--)
       {
           if (factDigits[i] == 0)
           {
               count++;
           }
           else
           {
               break;
           }
       }
       Console.WriteLine(count); */
   }
}
