using System;

//Write a program that takes as input a four-digit number in format abcd 
//(e.g. 2011) and performs the following:
//1.Calculates the sum of the digits (in our example  2 + 0 + 1 + 1 = 4 ) 
//and prints it on the console.
//2.Prints on the console the number in reversed order: dcba 
//(in our example 1102) and prints the reversed number.
//3.Puts the last digit in the first position: dabc 
//(in our example 1201) and prints the result.
//4.Exchanges the second and the third digits: acbd (in our example 2101) 
//and prints the result.


    class FourDigits
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int firstDigit = n % 10;
            int secondDigit = (n / 10) % 10;
            int thirdDigit = (n / 100) % 10;
            int fourDigit = (n / 1000) % 10;

            int sum = firstDigit + secondDigit + thirdDigit + fourDigit;

            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourDigit);
            Console.WriteLine("{0}{1}{2}{3}", firstDigit, fourDigit, thirdDigit, secondDigit);
            Console.WriteLine("{0}{1}{2}{3}", fourDigit, secondDigit, thirdDigit, firstDigit);

           
            //int number = int.Parse(Console.ReadLine())

            //int digit = number % 10;
            //int remainder = number / 10;
            ////Console.WriteLine("{0} {1}", digit, remainder);
            //Console.WriteLine(digit);

            //while (remainder != 0)
            //{
            //    digit = remainder % 10;
            //    remainder = remainder / 10;
            //    Console.WriteLine(digit);
            //}
            
        }
    }
