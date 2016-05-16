using System;
/*
Write a program that shows the binary representation of given 16-bit signed integer number N (the C# type  short ).

Input
•On the only line you will receive a decimal number - N

Output
•Print the its binary representation on a single line ◦There should be exactly 16 digits of output


Constraints
•-2^15 <= N < 2^15
•Time limit: 0.1s
•Memory limit: 16MB

11  -> 0000000000001011 
-11 -> 1111111111110101 

*/
class BinaryShort
{
   static int nbrBits = 16; //short

   static void Main()
   {
       //short number = short.Parse(Console.ReadLine()); 
       //[-32,768, 32,767] but number has to be [-32,768, 32,768]
       int number = int.Parse(Console.ReadLine());
       string binary = "";
       string numberValue = "";
       

       if (number >= 0)
       {
           // format 0XXXXXXXXXXXXXXXX  where XXXXXXXXXXXXXXXX = decimal value of the last 15 bits
           binary += '0';
           binary += ConvertDecimalToBinary(number);
       }
       else if (number < 0)
       {
           // format 1XXXXXXXXXXXXXXXX where XXXXXXXXXXXXXXXX = 2^15 - decimal value of the last 15bits
           binary += '1';
           int numberToConvert = (int)Math.Pow(2, nbrBits - 1) - Math.Abs(number);

           numberValue = ConvertDecimalToBinary(numberToConvert);
           binary += numberValue;
       }

       Console.WriteLine(binary);
   }

   static string ConvertDecimalToBinary(long n)
   {
       string tempResult = "";
       string binary = "";
       while (n > 0)
       {
           long remainder = n % 2;
           tempResult += remainder;
           n = n / 2;
       }

       //reverse temp result 
       for (int i = tempResult.Length - 1; i >= 0; i--)
       {
           binary += tempResult[i];
       }

       if (binary.Length < nbrBits - 1)
       {
           return AddLeadingZeros(binary);
       }

       return binary;
   }

   static string AddLeadingZeros(string binary)
   {
       //add 16-1 leading zeros, the first 0 is added for the positive sign of the number
       //nbrBit - 1
       string binaryWithZeros = "";
       if (binary.Length < nbrBits-1)
       {
           int nbrLeadingZeros = nbrBits - 1 - binary.Length; //15 - length
           for (int i = 0; i < nbrLeadingZeros; i++)
           {
               binaryWithZeros += '0';
           }
           binaryWithZeros += binary;
       }
       return binaryWithZeros;
   }
}
