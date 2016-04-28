using System;
using System.Text;

//Write a program that prints an isosceles triangle of 9 copyright symbols  © , something like this:
//   ©

//  © ©

// ©   ©

//© © © ©

class IsoscelesTriangle
{
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            char copyright = '\u00A9';

            Console.WriteLine("   {0}   ", copyright);
            Console.WriteLine("  {0} {0}  ", copyright);
            Console.WriteLine(" {0}   {0} ", copyright);
            Console.WriteLine("{0} {0} {0} {0}",copyright);
        }
}