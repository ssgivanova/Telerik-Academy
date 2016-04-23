using System;

class BinaryDigits
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int rows = 4;

        //print the corresponding pattern for all the 4 rows
        for (int row = 0; row < rows; row++)
        {
            //print the pattern of each row
            //get the bit value of the last 16 bits of the number
            for (int p = 15; p >= 0; p--)
            {
                int mask = 1 << p;
                int nAndMask = mask & n;
                int bit = nAndMask >> p;
                //Console.Write(bit +" ");

                if (bit == 0)
                {
                    switch (row)
                    {
                        case 0:
                        case 3: Console.Write("###"); break;
                        case 1:
                        case 2: Console.Write("#.#"); break;
                    }
                }
                else if (bit == 1)
                {
                    switch (row)
                    {
                        case 0: Console.Write(".#."); break;
                        case 1: Console.Write("##."); break;
                        case 2: Console.Write(".#."); break;
                        case 3: Console.Write("###"); break;
                    }
                }
                //not add "." after the last bit
                if (p > 0)
                {
                    Console.Write(".");
                }
            }
            //go to the next line to print the next row pattern
            Console.WriteLine();
        }
    }
}
