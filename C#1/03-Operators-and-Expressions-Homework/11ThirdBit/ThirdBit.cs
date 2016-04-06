using System;

//Using bitwise operators, write a program that uses an expression to find 
//the value of the bit at index 3 of an unsigned integer read from the console.
//•The bits are counted from right to left, starting from bit 0.
//•The result of the expression should be either 1 or 0. Print it on the console.

//output:
//single number - 1 or 0 - the value of the 3rd bit, counted from 0 and from 
//right to left.

    class ThirdBit
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = 3;
            uint mask = (uint)(1 << p);
            uint nAndMask = n & mask;
            uint bit = nAndMask >> p;
            Console.WriteLine(bit);
        }
    }
