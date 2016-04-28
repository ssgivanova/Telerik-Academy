using System;

//Write a program that reads an integer from the console, 
//uses an expression to check if given integer is odd or even, 
//and prints "even NUMBER" or "odd NUMBER", where you should print 
//the input number's value instead of NUMBER.

//input : the number
//output :
//Output a single line - if the number is even, output even, 
//followed by a whitespace and the value of the number. 
//Otherwise, print odd, again followed by a whitespace and the number's value.

class OddOrEven
{
        static void Main()
        {
            sbyte n = sbyte.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("even {0}", n);
            }
            else
            {
                Console.WriteLine("odd {0}", n);
            }
        }
}