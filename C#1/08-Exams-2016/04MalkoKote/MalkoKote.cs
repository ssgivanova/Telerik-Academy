using System;

/*
 * n = 10
0 .#.#.....
1 .###.....
2 ..#......
3 .###.....
4 .###...##
5 #####..#.
6 #####..#.
7 #####..#.
8 #####.##.
9 .######..
 
 n=14

0  .$..$
1  .$$$$
2  .$$$$
3  ..$$
4  ..$$
5  .$$$$
6  .$$$$
7  .$$$$   $$$
8  $$$$$$  $
9  $$$$$$  $
10 $$$$$$  $
11 $$$$$$  $
12 $$$$$$ $$
13  $$$$$$$
 * */

/*n=18
 %...%
 %%%%%
 %%%%%
 %%%%%
..%%%
..%%%
..%%%
.%%%%%
.%%%%%
.%%%%%
.%%%%%   %%%%
%%%%%%%  %
%%%%%%%  %
%%%%%%%  %
%%%%%%%  %
%%%%%%%  %
%%%%%%% %%
 %%%%%%%%

*/
class MalkoKote
{
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int symbolCode = Console.Read();
            char symbol = (char)symbolCode;

            char space = '\u0020';

            int cat = n / 2;
            int countCat = cat - 1;

            int countVrat = (countCat - 1 - 1) / 2;
            //int spaceVrat = (countCat - countVrat+ 1) / 2;
            int spaceVrat = 2;

            int spaceHead = (cat - 2 - 1) / 2; //2#, 1.,space
            int leftHead = n - 1 - 2 - spaceHead;

            int tail = spaceHead + 1;
            int left = n - cat - tail;




            //Console.WriteLine("cat"+cat);
            //Console.WriteLine("left" + left);
            //Console.WriteLine("head" + spaceHead);
            //Console.WriteLine("vrat" + countVrat);
            //Console.WriteLine("razstoqnie do vrat" + spaceVrat);

            Console.WriteLine();

            //first line - ushi
            Console.Write(space);
            Console.Write(symbol);
            Console.Write(new string(space, spaceHead));
            Console.Write(symbol);
            Console.Write(new string(space, leftHead));
            Console.WriteLine();

            int indexHead = 0;
            //glava
            for (int i = 1; i < spaceHead + 1; i++)
            {
                Console.Write(space);
                Console.Write(new string(symbol, spaceHead + 2));
                Console.Write(new string(space, spaceHead + n / 2));
                Console.WriteLine();

                indexHead = i;
            }
            //vrat
            for (int i = indexHead + 1; i < 2 * spaceHead + 1; i++)
            {
                //Console.Write(new string(space, spaceHead));
                //Console.Write(new string(symbol, spaceHead));
                //Console.Write(new string(space, spaceHead +n / 2 + 1));

                Console.Write(new string(space, spaceVrat));
                Console.Write(new string(symbol, countVrat));
                Console.Write(new string(space, spaceVrat + n / 2 + 1));
                Console.WriteLine();

                indexHead = i;
            }

            //gorna chast na tqloto
            for (int i = indexHead + 1; i <= n / 2; i++)
            {
                //int count = n - cat;
                //int leftHead = n - 1 - 2 - spacehead;
                Console.Write(space);
                Console.Write(symbol);
                Console.Write(new string(symbol, spaceHead));
                Console.Write(symbol);

                if (i == n / 2) //opa6ka
                {
                    Console.Write(new string(space, n - left - n / 2));
                    Console.Write(new string(symbol, tail));
                    Console.Write(new string(space, left - 1));
                }
                else
                {
                    Console.Write(new string(space, leftHead));
                }
                Console.WriteLine();
                indexHead = i;
            }


            //dolna chast na tqloto
            for (int i = indexHead; i <= n - 1; i++)
            {
                //Console.WriteLine(i);
                int countLeft = n - countCat;
                Console.Write(new string(symbol, countCat));
                Console.Write(new string(space, 2));
                Console.Write(new string(symbol, 1));
                Console.Write(new string(space, n - countCat - 3));

                //predposleden red
                if (i == n - 1)
                {
                    Console.WriteLine();
                    Console.Write(new string(symbol, countCat));
                    Console.Write(new string(space, 1));
                    Console.Write(new string(symbol, 2));
                    Console.Write(new string(space, n - countCat - 2));
                }
                Console.WriteLine();

            }

            //posleden red
            Console.Write(new string(space, 1));
            Console.Write(new string(symbol, countCat + 2 + 1 - 3));
            Console.Write(new string(space, n - (countCat + 2)));
            Console.WriteLine();
        }
}
