using System;

//Write a program that reads from the console two integer numbers P and N 
//and prints on the console the value of P's N-th bit. 

//N will be a positive integer and always smaller than 55.
//0 <= P <= 2^55


    class NthBit
    {
        static void Main()
        {
            //the number p
            long p = long.Parse(Console.ReadLine());
            //the position on which we are looking for the bit value
            byte n = byte.Parse(Console.ReadLine());

            int mask = (int)(1 << n);
            long nAndMask = p & mask;
            long bit = nAndMask >> n;

            //binary representation of the number
            //Console.WriteLine(Convert.ToString(p,2).PadLeft(16,'0'));

            Console.WriteLine(bit);
            

            
        }
    }
