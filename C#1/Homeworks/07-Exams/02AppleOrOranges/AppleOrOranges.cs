using System;
class AppleOrOranges
    {
        static void Main(string[] args)
        {
            long n = Math.Abs(long.Parse(Console.ReadLine()));
            
            int sumEven = 0;
            int sumOdd = 0;            

            int digit = 0;

            while (n > 0)
            {
                digit = (int)(n % 10);
                n = n / 10;
                if (digit % 2 == 0)
                {
                    sumEven += digit;
                }
                else
                {
                    sumOdd += digit;
                }
            }

            if (sumOdd > sumEven)
            {
                Console.WriteLine("oranges {0}", sumOdd);
            }
            else if (sumEven > sumOdd)
            {
                Console.WriteLine("apples {0}", sumEven);
            }
            else
            {
                Console.WriteLine("both {0}", sumEven);
            }
        }
    }
