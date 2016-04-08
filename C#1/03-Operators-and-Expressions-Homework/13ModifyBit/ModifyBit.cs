using System;

//We are given an integer number N(read from the console), a bit value v(read from the console as well) 
//(v = 0 or 1) and a position P(read from the console). Write a sequence of operators (a few lines of 
//C# code) that modifies N to hold the value v at the position P from the binary representation of N 
//while preserving all other bits in N. Print the resulting number on the console.

//input :
//First line - the integer number N.
//Second line - the position P.
//Third line - the bit value v.

//output : 
//single line containing the value of the number N with the modified bit



class ModifyBit
 {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            byte p = byte.Parse(Console.ReadLine());
            byte v = byte.Parse(Console.ReadLine());

            //binary representation of n
            //Console.WriteLine(Convert.ToString(n,2).PadLeft(16,'0'));

            //get the current bit value
            ulong mask = (ulong)(1 << p);
            ulong nAndMask = n & mask;
            ulong currentBit = nAndMask >> p;
            //Console.WriteLine("current bit = " + currentBit);

            ulong result = 0;
            ulong bit;

            //the bit has to be changed to 0
            if (v == 0)
            {
                if (currentBit == 0)
                {
                    //no change need
                    //Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
                    result = n;
                    Console.WriteLine(result);
                }
                else if (currentBit == 1)
                {
                    //set the current bit to 0
                    ulong invertedMask = ~mask; // ~(1 << p)
                    result = n & invertedMask;
                    //Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
                    //bit = nAndInvertedMask >> p;
                    //Console.WriteLine("new bit = "+bit);
                    Console.WriteLine(result);
                }
            }

            if (v == 1)
            {
                if (currentBit == 0)
                {
                    //set the bit to 0
                    result = n | mask; // n | (1 <<p)
                    bit = result >> p;
                    //Console.WriteLine("new bit = " + bit);
                    Console.WriteLine(result);
                    
                }
                if (currentBit == 1)
                {
                    //no change needed
                    //Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
                    result = n;
                    Console.WriteLine(result);
                }
            }


        }
 }
