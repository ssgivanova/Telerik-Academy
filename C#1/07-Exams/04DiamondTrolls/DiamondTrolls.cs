using System;
class DiamondTrolls
{
   static void Main()
    {

       int n = int.Parse(Console.ReadLine());
        //int n = 7;

       int w = 2 * n + 1;
       int h = 6 + ((n - 3) * 2) / 3;

       //top of the diamond
       Console.Write(new string('.',(w-n)/2));
       Console.Write(new string('*', n));
       Console.Write(new string('.', (w - n) / 2));
       Console.WriteLine();

       int dots = (w - n) / 2;
       
       for (int i = dots - 1; i > 0; i--)
       {
           Console.Write(new string('.',i));
           Console.Write("*");
           Console.Write(new string('.', n-i-1));
           Console.Write("*");
           Console.Write(new string('.', n - i - 1));
           Console.Write("*");
           Console.Write(new string('.', i));
           Console.WriteLine();
       }

       //line with * only
       Console.Write(new string('*',w));
       Console.WriteLine();

       //part2 1-7. 
       for (int i = 1; i < n; i++)
       {
           Console.Write(new string('.',i));
           Console.Write("*");
           Console.Write(new string('.', n-i-1));
           Console.Write("*");
           Console.Write(new string('.', n - i - 1));
           Console.Write("*");
           Console.Write(new string('.', i));
           Console.WriteLine();
       }

        //last line - .......*.......
       Console.Write(new string('.', n));
       Console.Write("*");
       Console.Write(new string('.', n));
       Console.WriteLine();
    }
}
