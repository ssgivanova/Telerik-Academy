using System;
class Fire
{
   static void Main()
   {
       int n = int.Parse(Console.ReadLine());
       //int n = 12;
       int w = n;
       int top = 2;
       int fireTop = n / 2;
       int fireBottom = fireTop/ 2; //=n/4
       int torch = n / 2;


       int dotsOut = (w - top) / 2; // = n/2
       int dotsIn = n - 2; // n-2-2*i

       //top part of the fire
       for (int i = fireTop-1; i >= 0; i--)
       {
           dotsOut = i;
           dotsIn = n - 2 - 2 * i;
           Console.Write(new string('.',dotsOut));
           Console.Write("#");
           Console.Write(new string('.', dotsIn)); 
           Console.Write("#");
           Console.Write(new string('.', i));
           Console.WriteLine();
       }

       //bottom part of the fire
       for (int i = 0; i < fireBottom; i++)
       {
           dotsOut = i;
           dotsIn = n - 2 - 2 * i;
           Console.Write(new string('.',dotsOut));
           Console.Write("#");
           Console.Write(new string('.', dotsIn));
           Console.Write("#");
           Console.Write(new string('.', i));
           Console.WriteLine();
       }

       //line
       Console.Write(new string('-',w));
       Console.WriteLine();

       //torch
       for (int i = 0; i < torch; i++)
       {
           dotsOut = i;
           int torchLines = n/2 - i;
           Console.Write(new string('.', dotsOut));
           Console.Write(new string('\\', torchLines));
           Console.Write(new string('/', torchLines));
           Console.Write(new string('.', dotsOut));
           Console.WriteLine();
       }
   }
}
