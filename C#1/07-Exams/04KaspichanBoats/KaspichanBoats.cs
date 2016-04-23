using System;
/* n =7
0 .......*.......
1 ......***......
2 .....*.*.*.....
3 ....*..*..*....
4 ...*...*...*...
5 ..*....*....*..
6 .*.....*.....*.
7 ***************
8 .*.....*.....*.
9 ..*....*....*..
10 ...*...*...*...
11 ....*******....
*/
class KaspichanBoats
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //int n = 7;

        int w = 2 * n + 1;
        int h = 6 + ((n - 3) * 2) / 3;

        int dots = (w - n) / 2;
        int bottom = (w - n) / 2;


        //top line
        // .......*.......
        Console.Write(new string('.', n));
        Console.Write("*");
        Console.Write(new string('.', n));
        Console.WriteLine();

        //top part of the boat
        for (int i = n-1; i >= 1; i--)
        {
            Console.Write(new string('.', i));
            Console.Write("*");
            Console.Write(new string('.', n - i - 1));
            Console.Write("*");
            Console.Write(new string('.', n - i - 1));
            Console.Write("*");
            Console.Write(new string('.', i));
            Console.WriteLine();
        }

        //middle part - * only
        Console.Write(new string('*', w));
        Console.WriteLine();

        //bottom part of the boat
        for (int i = 1; i < bottom; i++)
        {
            Console.Write(new string('.', i));
            Console.Write("*");
            Console.Write(new string('.',n-1-i));
            Console.Write("*");
            Console.Write(new string('.', n - 1 - i));
            Console.Write("*");
            Console.Write(new string('.', i));
            Console.WriteLine();
        }

        //bottom line
        Console.Write(new string('.', bottom));
        Console.Write(new string('*', n));
        Console.Write(new string('.', bottom));
        Console.WriteLine();
    }
}
