using System;
/*
Write a program that converts a hexadecimal number N to its decimal representation.

Input
On the only line you will receive a hexadecimal number - N 
There will not be leading zeros
Letters will be uppercase

Output
Print the decimal representation of N on a single line
There should not be leading zeros

Constraints
•1 <= N <= 10^18 = DE0B6B3A7640000(16)
•Time limit: 0.1s
•Memory limit: 16MB
 * 
 1F4 -> 500, 
*/
class HexadecimalToDecimal
{
    static void Main()
    {
        string hexadecimal = Console.ReadLine();
        long result = ConvertHexadecimalToDecimal(hexadecimal);
        Console.WriteLine(result);
    }

    static long ConvertHexadecimalToDecimal(string hexadecimal)
    {
        long sum = 0;
        int n = hexadecimal.Length;
        for (int i = n - 1; i >= 0; i--)
        {
            //get digits
            int digit = 0;
            if (Char.IsDigit(hexadecimal[i]))
            {
                digit = hexadecimal[i] - '0';
            }
            else //if the digits is not a number [0,9]
                 //we have to change it to its corresponding value A-F : 10-15
            {
                switch (hexadecimal[i])
                {
                    case 'A': digit = 10; break;
                    case 'B': digit = 11; break;
                    case 'C': digit = 12; break;
                    case 'D': digit = 13; break;
                    case 'E': digit = 14; break;
                    case 'F': digit = 15; break;
                }
            }
            //calculate sum of powers of 16 
            //1F4 = 1*16^2 + 15*16^1 + 4*16^0  -> digit * 16 ^(n-i-1)
            int powerIndex = n - i - 1;
            long power = (long)Math.Pow(16, powerIndex);
            sum += digit * power;
        }
        return sum;
    }
}
