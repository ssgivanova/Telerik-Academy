using System;
using System.Threading;
using System.Globalization;

//Write a program that, depending on the first line of the input, reads an int, double or string variable.
//•If the variable is int or double, the program increases it by one.
//•If the variable is a string, the program appends * at the end.
//•Print the result at the console. Use switch statement.

//Input
//•On the first line you will receive the type of input as string in the following form: 
//◦integer for int
//◦real for double
//◦text for string

//•On the second line you will be given the value of the variable.

//Output
//•Write a single line on the console - the value transformed according to the rules from the description.
//◦Print all double variables with exactly 2-digits precision after the floating point. Example: 0.99

//•The input will always be valid and in the described format.
//•All input numbers will be between -1000 and 1000.


class IntDoubleString
 {
     static void Main()
     {
         Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

         string input = Console.ReadLine();
         
         switch (input)
         {
             case "integer" :
                 int n = int.Parse(Console.ReadLine());
                 n += 1;
                 Console.WriteLine(n);
                 break;
             case "real" :
                 double d = double.Parse(Console.ReadLine());
                 d += 1;
                 Console.WriteLine("{0:f2}",d);
                 break;
             case "text" :
                 string text = Console.ReadLine();
                 text += "*";
                 Console.WriteLine(text);
                 break;
         }
     }
}
