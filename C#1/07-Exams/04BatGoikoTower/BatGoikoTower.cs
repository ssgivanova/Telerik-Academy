using System;

/* n=11
0  ........../\..........
1  ........./--\.........
2  ......../....\........
3  ......./------\.......
4  ....../........\......
5  ...../..........\.....
6  ..../------------\....
7  .../..............\...
8  ../................\..
9  ./..................\.
10 /--------------------\

*/
class BatGoikoTower
{
    static void Main()
    {

        
        int n = int.Parse(Console.ReadLine());
        //int n = 11;

        int w = n;
        int h = 2 * n;

        int dotsOut = 0;
        int dotsIn = 0;

        int linesIndex = 0;
        int valueForLine = 1;
        int step = 2;
        //dots out right
        for (int i= n-1; i>=0; i--)
        {
            dotsOut = i;
            dotsIn = 2 * n - 2 - 2 * i;
            linesIndex = n - 1 - i;
            
            Console.Write(new string('.',dotsOut));
            Console.Write('/');

            //calculates index for lines --
            //1,3,6,... valueForLine + incrementing step
            if (linesIndex > 0 && (linesIndex % valueForLine == 0))
            {
                Console.Write(new string('-', dotsIn));
                valueForLine += step;
                step++;
            }
            else
            {
                Console.Write(new string('.', dotsIn));
            }

            Console.Write('\\');
            Console.Write(new string('.', dotsOut));
            Console.WriteLine();
        }
     }
 }
