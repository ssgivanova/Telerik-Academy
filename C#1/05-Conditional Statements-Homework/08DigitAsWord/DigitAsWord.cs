using System;
using System.Threading;
using System.Globalization;

//Write a program that read a digit (0-9) from the console, and depending on the input, 
//shows the digit as a word (in English).
//•Print "not a digit" in case of invalid input.
//•Use a switch statement.

//Input
//•The input consists of one line only, which contains the digit.

//Output
//•Output a single line - should the input be a valid digits, print the english word for the digits. 
//Otherwise, print "not a digit".

//Constraints
//•The input will never be an empty line.

class DigitAsWord
 {
     static void Main()
     {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int n;
        string input = Console.ReadLine();
        if (int.TryParse(input, out n))
        {
            switch (n)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                default: Console.WriteLine("not a digit"); break;
            }
        }
        else
        {
            Console.WriteLine("not a digit");
        }
     }
}
