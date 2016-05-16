using System;
/*
Write a program that shows the internal binary representation of given 32-bit signed floating-point number
in IEEE 754 format (the C# type  float ).

Input
•On the only line you will receive a decimal number - N

Output
•Print the its binary representation on a single line ◦There should not be leading zeros

Constraints
•1 <= N <= 10^19 
•Time limit: 0.1s
•Memory limit: 16MB
 * 
 -27,25 -> sign 1, exponent -> 10000011, mantissa -> 10110100000000000000000 

 */
class BinaryFloatingPoint
{
    static void Main()
    {
        /*
        double number = double.Parse(Console.ReadLine());

        string binary = "";

        int sign = 0;
        int exponentNum = 0;
        double mantissaNum = 0;

        string exponent = "";
        string mantissa = "";

        //sign
        if (number < 0)
        {
            sign = 1;
        }
        else
        {
            sign = 0;
        }
        binary += sign;

        //exponent
        int k = 0;
        int num = 0;
        while (num < Math.Abs(number))
        {
            k++;
            num = (int)Math.Pow(2,k);
        }
        exponentNum = k-1;
        mantissaNum = Math.Abs(number) / (int)Math.Pow(2, exponentNum);

        exponent = ConvertDecimalToBinary(exponentNum);

        Console.WriteLine("sign - {0}, exponent - {1}, mantissa - {2}",sign, exponentNum, mantissaNum);
        Console.WriteLine("sign - {0}, exponent - {1}, mantissa - {2}", sign, exponent, mantissa);
        */

        // TODO: There should not be leading zeros
        // Possibly incorrect output formatting

        // input
        float toDisplayInput = float.Parse(Console.ReadLine());

        float toDisplay = toDisplayInput;
        // string 
        string toPrint = "";

        string[] BinKey = "0 1".Split(' ');

        // bit 31 -> 0 positive, 1 negative
        string SignString = "0";

        if (toDisplayInput < 0)
        {
            SignString = "1";
            toDisplay = Math.Abs(toDisplay);
        }

        //calculate exponent
        // get nuumber in format 1+ 0.xxxxxxx
        int powCounter = 0;
        while (!(toDisplay >= 1 && toDisplay < 2))
        {
            toDisplay /= 2;
            powCounter++;
        }

         // number part
        // TODO: to binary fraction
        // bits 0 -23
        float Number = toDisplay - 1;

        string NumString = "";

        // end when num = 0 
        // nothing to multiply
        while (Number != 0 &&
               NumString.Length <= 23)
        {
            // Step 1: Multiply by 2
            Number *= 2;

            if (Number >= 1)          // if result larger than 1
            {                        //
                NumString += "1";    // add 1
                Number -= 1;          // remove the int part (1 )
            }                        //
            else                     // if not
            {                        //
                NumString += "0";    // add 0
            }                        // keep result
        }
        // add trailing 0s 23 bits length
        NumString = NumString.PadRight(23, '0');

        // TODO: to binary
        // bits 30 - 24
        int Power = 127 + powCounter;

        string PowString = Convert.ToString(Power, 2);

        // 8 bits
        PowString = PowString.PadLeft(8, '0');



        toPrint = SignString + PowString + NumString;

        Console.WriteLine(toPrint);

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
        return binary;
    }
}
