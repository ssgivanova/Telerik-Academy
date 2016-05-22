using System;

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
//percentage and in scientific notation. Format the output aligned right in 15 symbols.

class FormatNumber
{
   static void Main()
   {
       int num = int.Parse(Console.ReadLine());

       string strDecimal = String.Format("{0,15:D}",num);
       Console.WriteLine(strDecimal);

       string strHexadecimal = String.Format("{0,15:X}", num);
       Console.WriteLine(strHexadecimal);

       string strPercentage = String.Format("{0,15:P2}", num/100.0);
       Console.WriteLine(strPercentage);

       string strExponent = String.Format("{0,15:E}", num);
       Console.WriteLine(strExponent);
      
   }
}
