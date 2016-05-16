using System;
/*
Write a program that converts a binary number N to its decimal representation.

Input
•On the only line you will receive a binary number - N ◦There will not be leading zeros

Output
•Print the decimal representation of N on a single line ◦There should not be leading zeros

Constraints
•1 <= N <= 10^18 = 110111100000101101101011001110100111011001000000000000000000(2)
•Time limit: 0.1s
•Memory limit: 16MB
*/
class BinaryToDecimal
{
   static void Main()
   {
       string binary = Console.ReadLine();
       long result = ConvertBinaryToDecimal(binary);
       Console.WriteLine(result);
   }

   //the max bin number by constraint is 110111100000101101101011001110100111011001000000000000000000
   //110111100000101101101011001110100111011001000000000000000000 = 1000000000000000000 = 10 ^ 19 -> long
   static long ConvertBinaryToDecimal(string binary)
   {
       long sum = 0;
       int n = binary.Length;
       for (int i = n - 1; i >= 0; i--)
       {
           //get digits
           int digit = binary[i] - '0';
           //calculate sum of powers of 2 
           //10011 = 1*2^4 + 0*2^3 + 0*2^2 + 1*2^1 + 1*2^0 -> digit * 2 ^(n-i-1)
           int powerIndex = n - i - 1;
           long power = (long)Math.Pow(2, powerIndex);
           sum += digit * power;
       }
       return sum;
   }
}
