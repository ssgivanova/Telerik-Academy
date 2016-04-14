using System;

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned 
//integer(read from the console).

//Input :
//On the only input line you will receive the unsigned integer number whose bits you must exchange.

//Output :
//On the only output line print the value of the integer with the exchanged bits.
//N will always be a valid 32-bit unsigned integer.


    class BitExchange
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());

            int pos3 = 3;
            int pos4 = 4;
            int pos5 = 5;
            int pos24 = 24;
            int pos25 = 25;
            int pos26 = 26;
            uint result = n;

            // get the bits
            uint nAndMask3 = (uint)(n & (1 << pos3)) ;
            uint bit3 = nAndMask3 >> pos3;

            uint nAndMask4 = (uint)(n & (1 << pos4));
            uint bit4 = nAndMask4 >> pos4;

            uint nAndMask5 = (uint)(n & (1 << pos5));
            uint bit5 = nAndMask5 >> pos5;

            uint nAndMask24 = (uint)(n & (1 << pos24));
            uint bit24 = nAndMask24 >> pos24;

            uint nAndMask25 = (uint)(n & (1 << pos25));
            uint bit25 = nAndMask25 >> pos25;

            uint nAndMask26 = (uint)(n & (1 << pos26));
            uint bit26 = nAndMask26 >> pos26;

            //Console.WriteLine("bit3 " + bit3);
            //Console.WriteLine("bit24 "+bit24);

            //exchange 3 and 24 bits
            
            if (bit3 == bit24)
            { 
                //no change
            }
            else if (bit3 == 0 && bit24 == 1)
            {
                //set bit3 to 1 
                result = ((uint)1 << pos3) | result ;
                
                //set bit24 to 0
                result = (~((uint)1 << pos24)) & result;

            }
            else if (bit3 == 1 && bit24 == 0)
            {
                //set bit3 to 0
                result = (~((uint)1 << pos3)) & result;

                //set bit24 to 1
                result = ((uint)1 << pos24) | result;

            }

            //exchange 4 and 25 bits

            if (bit4 == bit25)
            {
                //no change
            }
            else if (bit4 == 0 && bit25 == 1)
            {
                //set bit4 to 1 
                result = ((uint)1 << pos4) | result;
                
                //set bit25 to 0
                result = (~((uint)1 << pos25)) & result;

            }
            else if (bit4 == 1 && bit25 == 0)
            {
                //set bit4 to 0
                result = (~((uint)1 << pos4)) & result;

                //set bit25 to 1
                result = ((uint)1 << pos25) | result;
            }

            //exchange 5 and 26 bits

            if (bit5 == bit26)
            {
                //no change
            }
            else if (bit5 == 0 && bit26 == 1)
            {
                //set bit5 to 1 
                result = ((uint)1 << pos5) | result;
                //set bit26 to 0
                result = (~((uint)1 << pos26)) & result;

            }
            else if (bit5 == 1 && bit26 == 0)
            {
                //set bit5 to 0
                result = (~((uint)1 << pos5)) & result;

                //set bit26 to 1
                result = ((uint)1 << pos26) | result;
            }

            Console.WriteLine("before exchange");
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("after exchange");
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
            Console.WriteLine(result);
        }
    }
