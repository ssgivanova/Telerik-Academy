using System;

/* n= 6
.......*****.......
.....*.......*.....
...*...........*...
.*...............*.
.*...............*.
.*@.@.@.@.@.@.@.@*.
.*.@.@.@.@.@.@.@.*.
.*...............*.
.*...............*.
...*...........*...
.....*.......*.....
.......*****.......
 */

class Eggcelent
 {
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //int n = 6;

        int w = 3 * n - 1;
        int h = 2 * n;
        int area = 3 * n + 1;
        int top = n - 1;
        int bottom = n - 1;

        int dotsOut = (area - top) / 2;

        //print interior dots : 7,11,15 -> width egg - 2 (shell)
        int dotsIn = w - 2;

        int interiorEgg = h - 2; //without the top and bottom side of the shell
        
        //top side
        Console.Write(new string('.',dotsOut));
        Console.Write(new string('*', top));
        Console.Write(new string('.', dotsOut));
        Console.WriteLine();

        //top out side 
        //dots outside : 5,3,1 
        for (int i = dotsOut-2; i > 0; i -= 2)
        {
            //5 3 1
            Console.Write(new string('.', i));
            Console.Write("*");

            //print interior dots : 7,11,15 -> width egg - 2 (shell) -2*(i-1) = (w-2)-2(i-1)= w-2*i
            //= dotsIn - 2(i-1)
            Console.Write(new string('.', dotsIn - 2*(i-1)));
            Console.Write("*");
            Console.Write(new string('.', i));

            Console.WriteLine();
        }

        //middle of the egg = heiht egg - top side -bottom side - 2lines cracks
        //the 2 parts are symetric -> divide en 2 equal parts (h - 2 - 2)/2; -> 4 middle rows
        int middleRows = (h - 2 - 2)/2;

        for (int i = 0; i < middleRows; i++)
        {
            Console.Write(".");
            Console.Write("*");
            //print middle cracks
            for (int j = 0; j < (w - 2); j++)
            {
                if (i == middleRows / 2 || i == (middleRows / 2) - 1)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("@");
                        //Console.Write(".");
                    }
                    else
                    {
                        Console.Write(".");
                        //Console.Write("@");
                    }
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.Write("*");
            Console.Write(".");
            Console.WriteLine();
        }

        //bottom out side 
        //dots outside : 5,3,1 
        for (int i = 1; i <= dotsOut - 2; i += 2)
        {
            //5 3 1
            Console.Write(new string('.', i));
            Console.Write("*");

            //print interior dots : 7,11,15 -> width egg - 2 (shell) -2*(i-1) = (w-2)-2(i-1)= w-2*i
            //= dotsIn - 2(i-1)
            Console.Write(new string('.', dotsIn - 2 * (i - 1)));
            Console.Write("*");
            Console.Write(new string('.', i));

            Console.WriteLine();
        }

        //bottom side
        Console.Write(new string('.', dotsOut));
        Console.Write(new string('*', bottom));
        Console.Write(new string('.', dotsOut));
        Console.WriteLine();
    }
 }
