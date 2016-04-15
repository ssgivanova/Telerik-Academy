using System;

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//•The input is entered as string. The output should be a variable of type long.
//•Do not use the built-in .NET functionality.

//Input
//•The input will consists of a single line containing a single hexadecimal number as string.

//Output
//•The output should consist of a single line - the decimal representation of the number as string.

//Constraints
//•All numbers will be valid 64-bit integers.

//FE 254 
//1AE3 6883 
//4ED528CBB4 338583669684 

class HexToDecimal
{
    static void Main()
    {
        long decimalNumber = 0L;
        double digit = 0;

        string hexNumber = Console.ReadLine();
        int n = hexNumber.Length;

        for (int i = n - 1; i >= 0; i--)
        {
            int power = n - i - 1;
            char digitHex = hexNumber[i];
            switch (digitHex)
            {
                case '1': digit = 1; break;
                case '2': digit = 2; break;
                case '3': digit = 3; break;
                case '4': digit = 4; break;
                case '5': digit = 5; break;
                case '6': digit = 6; break;
                case '7': digit = 7; break;
                case '8': digit = 8; break;
                case '9': digit = 9; break;
                case 'a':
                case 'A' : digit = 10; break;
                case 'b':
                case 'B': digit = 11; break;
                case 'c':
                case 'C': digit = 12; break;
                case 'd':
                case 'D': digit = 13; break;
                case 'e':
                case 'E': digit = 14; break;
                case 'f':
                case 'F': digit = 15; break;
                default: break;
            }
            decimalNumber += (long)(digit * Math.Pow(16, power));
        }
        Console.WriteLine(decimalNumber);

        Console.WriteLine(long.MaxValue);
    }
}