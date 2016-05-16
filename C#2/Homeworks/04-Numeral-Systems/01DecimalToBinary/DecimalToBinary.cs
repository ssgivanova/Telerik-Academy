using System;
/*
Write a program that converts a decimal number N to its binary representation.

Input
•On the only line you will receive a decimal number - N 
◦There will not be leading zeros

Output
•Print the binary representation of N on a single line ◦There should not be leading zeros

Constraints
•1 <= N <= 10^18
•Time limit: 0.1s
•Memory limit: 16MB
 
 * */
class DecimalToBinary
{
        static void Main()
        {
            //max n = 10 ^ 18 -> long
            long n = long.Parse(Console.ReadLine());
            string binary = ConvertDecimalToBinary(n);
            Console.WriteLine(binary);
        }

    static string ConvertDecimalToBinary(long n)
    {
        string tempResult ="";
        string binary = "";
        while (n > 0)
        {
            long remainder = n % 2;
            tempResult += remainder;
            n = n / 2;
        }
        
        //reverse temp result 
        for (int i = tempResult.Length -1; i >= 0; i--)
        {
            binary += tempResult[i]; 
        }
        return binary;
    }
}
