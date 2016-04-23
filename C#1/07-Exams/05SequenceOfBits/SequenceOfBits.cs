using System;

class SequenceOfBits
{
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            int countOnes = 0;
            int countZeros = 0;

            int maxOnes = 0;
            int maxZeros = 0;

            int lastBit = -1;

            // FIRST SOLUTION - WITH BITWISE OPERATIONS 

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                //get the most right 30 bits

                for (int p=29; p>=0; p--)
                {
                    //get bit at each position
                    int bit = ((1 << p) & num) >> p;
                    //Console.Write(bit + " ");

                    if (bit == 1)
                    {
                        if (lastBit == 1)
                        {
                            countOnes++;
                        }
                        else //lastBit = 0
                        {
                            countOnes = 1;
                        }
                        //get max ones
                        if (countOnes > maxOnes)
                        {
                            maxOnes = countOnes;
                        }
                    }
                    else //bit =0
                    {
                        if (lastBit == 0)
                        {
                            countZeros++;
                        }
                        else //lastBit = 1
                        {
                            countZeros = 1;
                        }
                        //get max zeros
                        if (countZeros > maxZeros)
                        {
                            maxZeros = countZeros;
                        }
                    }
                    lastBit = bit;     
                }
            }
            Console.WriteLine(countZeros);
            Console.WriteLine(countOnes);



            // SECOND SOLUTION - WITH SUBSTRING

            /*
             * 
            int countOnes = 0;
            int countZeros = 0;
            int longestSeqOnes = 0;
            int longestSeqZeros = 0;
            string result = "";

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                string binary = Convert.ToString(num,2).PadLeft(32,'0');
                string binaryRight30Bits = binary.Substring(2, binary.Length-2);

                //Console.WriteLine(binaryRight30Bits);
                result += binaryRight30Bits;
            }
            //Console.WriteLine(result);

            //iterate over result string
            foreach (char bit in result)
            {
                if (bit == '0')
                {
                    countZeros ++;
                    countOnes = 0;
                    if (countZeros > longestSeqZeros)
                    {
                        longestSeqZeros = countZeros;
                    }
                }
                else if (bit == '1')
                {
                    countOnes ++;
                    countZeros = 0;
                    if (countOnes > longestSeqOnes)
                    {
                        longestSeqOnes = countOnes;
                    }
                }
            }

            //output
            Console.WriteLine(longestSeqOnes);
            Console.WriteLine(longestSeqZeros); */
        }
}
