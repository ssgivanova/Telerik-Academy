using System;
using System.Text;

//Using loops write a program that converts an integer number to its binary representation.
//•The input is entered as long. The output should be a variable of type string.
//•Do not use the built-in .NET functionality.

//Input
//•On the only input line you will receive the decimal integer number.

//Output
//•Output a single string - the representation of the input decimal number in it's binary representation.

//Constraints
//•All numbers will always be valid 32-bit integers.

//0 0 
//3 11 
//43691 1010101010101011 
//236476736 1110000110000101100101000000 

class DecimalToBinary
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();
        String output = "";
        int bit;
        int division = 0;

        do
        {
            division = n / 2;
            bit = n % 2;
            sb.Append(bit);
            n = division;            
        }
        while (division != 0);
        output = sb.ToString();
        
        //without new array - inversing the string just for printing
        for (int i = output.Length-1; i >= 0 ; i--)
        {
            Console.Write(output[i]);
        }

        //char[] bits = output.ToCharArray();
        //Array.Reverse(bits);

        //foreach (char b in bits)
        //{
        //    Console.Write(b);
        //}



    }
}
