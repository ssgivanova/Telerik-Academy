using System;
/*
Write a program to convert hexadecimal numbers to binary numbers (directly).

Input
•On the only line you will receive a decimal number - N
There will not be leading zeros
Letters will be uppercase

Output
Print the its binary representation on a single line
There should not be leading zeros

Constraints
•1 <= N <= 10^18 = DE0B6B3A7640000(16)
•Time limit: 0.1s
•Memory limit: 16MB
 * 

DE0B6B3A7640000 =  110111100000101101101011001110100111011001000000000000000000
 */
class HexadecimalToBinary
{
   static void Main()
   {
       string hexadecimal = Console.ReadLine();
       string binary = ConvertHexadecimalToBinary(hexadecimal);
       Console.WriteLine(binary);
   }

   static string ConvertHexadecimalToBinary(string hexadecimal)
   {
       string result = "";
       int n = hexadecimal.Length;
       for (int i = 0; i < n; i++)
       {
           char digit = hexadecimal[i];
           string binaryPart = "";
           switch (digit)
           {
               case '0': binaryPart = "0000"; break;
               case '1': binaryPart = "0001"; break;
               case '2': binaryPart = "0010"; break;
               case '3': binaryPart = "0011"; break;
               case '4': binaryPart = "0100"; break;
               case '5': binaryPart = "0101"; break;
               case '6': binaryPart = "0110"; break;
               case '7': binaryPart = "0111"; break;
               case '8': binaryPart = "1000"; break;
               case '9': binaryPart = "1001"; break;
               case 'A': binaryPart = "1010"; break;
               case 'B': binaryPart = "1011"; break;
               case 'C': binaryPart = "1100"; break;
               case 'D': binaryPart = "1101"; break;
               case 'E': binaryPart = "1110"; break;
               case 'F': binaryPart = "1111"; break;
           }
           result += binaryPart;
       }
       //remove the leading zeros
       string resultNoLeadingZeros = "";
       for (int i = 0; i < result.Length; i++)
       {
           if (result[i] == '1')
           {
               resultNoLeadingZeros = result.Substring(i);
               break;
           }
       }
       if (hexadecimal.Equals("0")) //to work for the case 0
       {
           return "0";
       }

       return resultNoLeadingZeros;
   }
}
