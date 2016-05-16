using System;
/*
Write a program that converts a decimal number N to its hexadecimal representation.

Input
•On the only line you will receive a decimal number - N 
There will not be leading zeros

Output
•Print the hexadecimal representation of N on a single line
There should not be leading zeros
Use uppercase letters

Constraints
•1 <= N <= 10^18
•Time limit: 0.1s

 19 -> 13, 500 -> 1F4
 */
class DecimalToHexadecimal
{
    static void Main()
    {
        //max n = 10 ^ 18 -> long
        long n = long.Parse(Console.ReadLine());
        string hexNumber = ConvertDecimalToHexadecimal(n);
        Console.WriteLine(hexNumber);
    }

    static string ConvertDecimalToHexadecimal(long n)
    {
        string tempResult ="";
        string hexadecimal = "";
        while (n > 0)
        {
            long remainder = n % 16;
            char hexRemainder = '\0';
            switch (remainder)
            {
               case 0 : hexRemainder = '0';break;
               case 1: hexRemainder = '1'; break;
               case 2: hexRemainder = '2'; break;
               case 3: hexRemainder = '3'; break;
               case 4: hexRemainder = '4'; break;
               case 5: hexRemainder = '5'; break;
               case 6: hexRemainder = '6'; break;
               case 7: hexRemainder = '7'; break;
               case 8: hexRemainder = '8'; break;
               case 9: hexRemainder = '9'; break;
               case 10: hexRemainder = 'A'; break;
               case 11: hexRemainder = 'B'; break;
               case 12: hexRemainder = 'C'; break;
               case 13: hexRemainder = 'D'; break;
               case 14: hexRemainder = 'E'; break;
               case 15: hexRemainder = 'F'; break;
            }
            tempResult += hexRemainder; 
            n = n / 16;
        }
        
        //reverse temp result 
        for (int i = tempResult.Length-1; i >= 0; i--)
        {
            hexadecimal += tempResult[i]; 
        }
        return hexadecimal;
    }
}
