using System;
/*
Write a program to convert binary numbers to hexadecimal numbers (directly).

Input
•On the only line you will receive a decimal number - N ◦There will not be leading zeros

Output
•Print the its binary representation on a single line
There should not be leading zeros
Use uppercase letters

Constraints
•1 <= N <= 10^18 = 110111100000101101101011001110100111011001000000000000000000(2)
•Time limit: 0.1s
•Memory limit: 16MB

10011 -> 13 
 */
class BinaryToHexadecimal
{
    static void Main()
    {
        //0001101111100010 - > 1BE2
        string binary = Console.ReadLine();

        //add the leading zeros in the beginning if they are missing
        int nbrMissingBits = GetNumberMissingLeadingZeros(binary);        
        string filledBinary = FillWithLeadingZeros(binary,nbrMissingBits);

        //Console.WriteLine(nbrMissingBits);
        //Console.WriteLine(filledBinary);

        //convert
        string hexadecimal = ConvertBinaryToHexadecimal(filledBinary);
        Console.WriteLine(hexadecimal);
    }
    static int GetNumberMissingLeadingZeros(string binary)
    {
        int nbrMissingBits = 0;

        if (binary.Length % 4 != 0 )
        {
            int nbrFullBytes = binary.Length / 4;
            //Console.WriteLine("full " + nbrFullBytes);
            nbrMissingBits = 4 - (binary.Length - nbrFullBytes * 4);
            
        }
        return nbrMissingBits;
    }

    static string FillWithLeadingZeros(string binary, int countBitsToAdd)
    {
        string filled = "";

        if (countBitsToAdd > 0)
        {
            int totalLength = binary.Length + countBitsToAdd;

            for (int i = 0; i < totalLength; i++)
            {
                if (i < countBitsToAdd)
                {                    
                    filled += '0';
                }
                else
                {
                    filled += binary[i - countBitsToAdd];
                }
            }
            return filled;
        }
        return binary;
    }
    static string ConvertBinaryToHexadecimal(string binary)
    {
        string result = "";
        int n = binary.Length;
        int k = 4; //number of bits 

        for (int i = 0; i <= n - k; i += k)
        {
            string binaryPart = binary.Substring(i, k);

            char digit = '\0';
            switch (binaryPart)
            {
                case "0000": digit = '0'; break;
                case "0001": digit = '1'; break;
                case "0010": digit = '2'; break;
                case "0011": digit = '3'; break;
                case "0100": digit = '4'; break;
                case "0101": digit = '5'; break;
                case "0110": digit = '6'; break;
                case "0111": digit = '7'; break;
                case "1000": digit = '8'; break;
                case "1001": digit = '9'; break;
                case "1010": digit = 'A'; break;
                case "1011": digit = 'B'; break;
                case "1100": digit = 'C'; break;
                case "1101": digit = 'D'; break;
                case "1110": digit = 'E'; break;
                case "1111": digit = 'F'; break;
            }
            result += digit;
            //Console.WriteLine("i={0} binary part = {1} digit ={2}", i, binaryPart, digit);
        }
        return result;
    }
}
