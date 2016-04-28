using System;
class BinaryDigitsCount
{
        static void Main()
        {
            long bit = long.Parse(Console.ReadLine());
            long n = long.Parse(Console.ReadLine());
            long counter = 0;

            for (long i = 0; i < n; i++)
            {
                counter = 0;
                long num = long.Parse(Console.ReadLine());
                string numStr = Convert.ToString(num, 2);

                for (int p = 0; p < numStr.Length; p++)
                {
                    long currentBit = ((long)1 << p & num) >> p;

                    if (currentBit == bit)
                    {
                        counter++;
                    }
                }

                Console.WriteLine(counter);
            }

        }
}