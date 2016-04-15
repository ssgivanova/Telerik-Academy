using System;
using System.Text;

//Using loops write a program that converts an integer number to its hexadecimal representation.
//•The input is entered as long. The output should be a variable of type string.
//•Do not use the built-in .NET functionality.

//Input
//•On the first and only line you will receive an integer in the decimal numeral system.

//Output
//•On the only output line write the hexadecimal representation of the read number.

//Constraints
//•All numbers will always be valid 64-bit integers.

//254 FE 
//6883 1AE3 
//338583669684 4ED528CBB4 

class DecimalToHex
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();
        String output = "";
        long digit;
        long division = 0;

        do
        {
            char digitHex = '0';
            division = n / 16;
            digit = n % 16;
            switch (digit)
            {
                case 1: digitHex = '1'; break;
                case 2: digitHex = '2'; break;
                case 3: digitHex = '3'; break;
                case 4: digitHex = '4'; break;
                case 5: digitHex = '5'; break;
                case 6: digitHex = '6'; break;
                case 7: digitHex = '7'; break;
                case 8: digitHex = '8'; break;
                case 9: digitHex = '9'; break;
                case 10: digitHex = 'A'; break;
                case 11: digitHex = 'B'; break;
                case 12: digitHex = 'C'; break;
                case 13: digitHex = 'D'; break;
                case 14: digitHex = 'E'; break;
                case 15: digitHex = 'F'; break;
                default: break;
            }
            sb.Append(digitHex);
            n = division;
        }
        while (division != 0);
        output = sb.ToString();

        //without new array - inversing the string just for printing
        for (int i = output.Length - 1; i >= 0; i--)
        {
            Console.Write(output[i]);
        }
    }
}
