using System;
using System.Threading;
using System.Globalization;

//Write a program that reads 3 real numbers from the console and prints their sum.

//input :
//•On the first line, you will receive the number a
//•On the second line, you will receive the number b
//•On the third line, you will receive the number c


//output :
//Your output should consist only of a single line - the sum of the three numbers.

class Sum3Numbers
 {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            float sum = a + b + c;
            Console.WriteLine(sum);
        }
}
