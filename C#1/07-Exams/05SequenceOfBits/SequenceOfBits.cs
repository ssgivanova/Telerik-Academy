using System;

class SequenceOfBits
{
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            int countOnes = 0;
            int countZeros = 0;
            int longestSeqOnes = 0;
            int longestSeqZeros = 0;

            // FIRST SOLUTION - WITH SUBSTRING

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
            Console.WriteLine(longestSeqZeros);

            // SECOND SOLUTION - WITH BITWISE OPERATIONS 
        }
}
