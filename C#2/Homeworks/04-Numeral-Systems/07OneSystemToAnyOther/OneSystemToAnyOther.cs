using System;
/*
Write a program to convert the number N from any numeral system of given base s to any other numeral system of base d.

Input
•On the first line you will receive the number s
•On the second line you will receive a number in base s - N - There will not be leading zeros

•On the third line you will receive the number d

Output
•Print N in base d ◦There should not be leading zeros
◦Use uppercase letters

Constraints
•2 <= s, d <= 16
•1 <= N <= 10^18 
•Time limit: 0.1s
 
 */
class OneSystemToAnyOther
{
    static void Main()
    {
        int baseS = int.Parse(Console.ReadLine());
        string number = Console.ReadLine();
        int baseD = int.Parse(Console.ReadLine());

        string result = ConvertFromBaseSToBaseD(baseS, baseD, number);
        Console.WriteLine(result);
    }

    static string ConvertFromBaseSToBaseD(int s, int d, string number)
    {
        //convert first from base S to decimal 
        //then from decimal to base D

        long decimalNum = ConvertFromBaseSToDecimal(s, number);

        string result = ConvertFromDecimalToBaseD(d, decimalNum);
        return result;
    }

    static long ConvertFromBaseSToDecimal(int s, string number)
    {
        long decimalNum = 0;
        int n = number.Length;

        for (int i = 0; i < n; i++)
        {
            int digit = 0;

            if (number[i] <= '9' && number[i] >= '0') // number (0,9)
            {
                digit = number[i] - '0';
            }
            else // letter
            {
                // when the digit in this numberal system is letter A -> 10, B ->11, C -> 12 
                digit = number[i] - 'A' + 10;
            }

            int indexPower = n - i - 1;
            //Math.Pow is not precise for bigger integer number because result is double 
            // -> approximations -> incorrect result
            //or use BigInteger.Pow() -> in this case the result has to be BigInteger too
            //decimalNum += digit * BigInteger.Pow(s, indexPower);

            //use my method RaiseOnPower 
            decimalNum += digit * RaiseOnPower(s, indexPower);
        }
        return decimalNum;
    }

    static string ConvertFromDecimalToBaseD(int d, long decimalNum)
    {
        string converted = "";
        while (decimalNum > 0)
        {
            long remainder = decimalNum % d;
            char remainderToAdd = '\0';

            //number (0,9) -> digit
            //number > 9 = letter

            if (remainder <= 9)
            {
                remainderToAdd = (char)(remainder + '0'); // '0' = 48, we have to add '0' to receive the code 
            }
            else
            {

                remainderToAdd = (char)(remainder + 'A' - 10);
            }
            //Console.WriteLine("DIGIT REMAINDER {0}", remainderToAdd);

            converted += remainderToAdd;
            decimalNum = decimalNum / d;
        }

        //reverse result
        string result = ReverseString(converted);
        return result;
    }

    static string ReverseString(string s)
    {
        string reversed = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            reversed += s[i];
        }
        return reversed;
    }

    static long RaiseOnPower(int number, int power)
    {
        long numberOnPower = 1;

        for (int i = 0; i < power; i++)
        {
            numberOnPower *= number;
        }
        return numberOnPower;
    }
}
