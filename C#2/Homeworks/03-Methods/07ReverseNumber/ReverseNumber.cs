using System;
/*
 Write a method that reverses the digits of a given decimal number.

Input
•On the first line you will receive a number

Output
•Print the given number with reversed digits

Constraints
•Time limit: 0.1s
•Memory limit: 16MB

256 652 
123.45 54.321 

*/
class ReverseNumber
{
   static void Main()
   {
       //the input number can be integer or flotting point - so i consider it as string to reverse
       decimal nbr = decimal.Parse(Console.ReadLine());
       string reversed = ReverseString(nbr);
       Console.WriteLine(reversed);

       //second solution
       reversed = ReverseStringSecond(nbr);
       //Console.WriteLine(reversed);
   }
    static string ReverseString(decimal nbr)
    { 
        string str = nbr.ToString();
        string reversed = "";

        //if number is negative - remove the sign "-" and add it before the reversed number
        //-123 -> -321
        if (str[0] == '-')
        {
            str = str.Substring(1);
            reversed += '-';
        }
        
        for (int i = str.Length - 1; i >=0 ; i--)
	    {
            char element = str[i];
            reversed += element;
		}
        return reversed;
    }

    static string ReverseStringSecond(decimal nbr)
    {
        
        string reversed = "";

        //if number is negative - remove the sign "-" and add it before the reversed number
        //-123 -> -321
        if (nbr < 0)
        {
            nbr *= -1;
            reversed += '-';
        }

        char[] digits = nbr.ToString().ToCharArray();
        Array.Reverse(digits);
        reversed += new String(digits);
        
        return reversed;
    }
}

