using System;

//Using loops write a program that converts a binary integer number to its decimal form.
//•The input is entered as string. The output should be a variable of type long.
//•Do not use the built-in .NET functionality.

//Input
//•You will receive exactly one line containing an integer number representation in binary

//Output
//•On the only output line write the decimal representation of the number

//Constraints
//•All input numbers will be valid 32-bit integers

//0 0 
//11 3 
//1010101010101011 43691 
//1110000110000101100101000000 236476736 



class BinaryToDecimal
{
   static void Main()
   {
       long decimalNum = 0L;
       double digit = 0;

       string binary = Console.ReadLine();
       int n = binary.Length;

       for (int i = n - 1; i >= 0; i--)
       {
           int power = n - i - 1;
           digit = (binary[i] -'0') * Math.Pow(2, power);
           decimalNum += (long)digit;

           //Console.WriteLine("{0}*2^{1} = {2} ", binary[i], power, digit);
       }
       Console.WriteLine(decimalNum);
   }
}
