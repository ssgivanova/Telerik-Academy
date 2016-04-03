using System;

//Create a program that assigns null values to an integer 
//and to a double variable. 
//•Try to print these variables at the console. 
//•Try to add some number or the null literal to these variables and print 
//the result.

class NullValuesArithmetic
{
        static void Main()
        {
            int? n1 = null;
            double? n2 = null;

            Console.WriteLine(n1);
            Console.WriteLine(n2);

            n1 = 25;
            n2 = 12.56;

            Console.WriteLine(n1);
            Console.WriteLine(n2);

            n2 = null;
            Console.WriteLine(n2);
        }
}
