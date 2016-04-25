using System;
using System.Numerics;
class Secrets
{
   static void Main()
   {
       //because n can has <= 400 digits = 1.10^400 > long -> bigInteger
       BigInteger n = BigInteger.Parse(Console.ReadLine());
       BigInteger num = n;

       if (n < 0)
       {
           n *= -1;
       }

       //find odd and even sum
       //find special sum
       //find last digit of special sum = length of alpha sequence
       //find R = sum % 26;
       //find letters of the alphabets
       //find first letter of the sequence = R + 1 letter in alphabet
       //fill all the Length netx letters in the sequence
       //print special sum and sequence

       int sumOdd = 0;
       int sumEven = 0;
       int sum = 0;
       int position = 1;
       int digit = 0;

       //find number of digits
       int countDigits = 0;
       while (n > 0)
       {
           digit = (int)(n % 10);
           n = n / 10;
           countDigits++;
           //odd and even position sums
           if (position % 2 != 0)
           {
               sumOdd += digit * position * position;
           }
           else
           {
               sumEven += digit * digit * position;
           }
           position++;
        }
       sum = sumEven + sumOdd;

       int r = sum % 26;
       //length of the sequance = last digit of sum
       int length = sum % 10;

       //print letters
       //Console.WriteLine((int)'A'); //65
       //Console.WriteLine((int)'Z'); //90

       string result = "";
       int firstIndex = r + 1;

       //get first letter = the letter of the alphabet at position R+1 
       //char first = (char)(65 + firstIndex-1);
       char first = (char)('A'+ firstIndex -1);
       result += first;

       //create the alpha sequence - get the next letters
       char letter = first;
       for (int i = 1; i < length; i++)
       {
           letter ++;
           //if (letter > 'Z') //'Z'=90
           //{
           //    //"out of the alphabet" - first start again from A : remove the ascci code of Z (90)
           //    //so the index of the next letter is 1, and then add again 'A'
           //    letter = (char)(letter - 'Z');
           //    letter = (char)(letter + 'A' - 1);
           //}

           if (letter == 'Z') //'Z'=90
           {
              letter = 'A';
           }
           result += letter;
       }
       
       //output
       Console.WriteLine(sum);
       if (length == 0)
       {
           Console.WriteLine("{0} has no secret alpha-sequence", num);
       }
       else
       {
           Console.WriteLine(result);
       }
   }
}
