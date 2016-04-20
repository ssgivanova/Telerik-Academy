using System;

class AngryFemaleGPS
{
        static void Main()
        {
            //Console.WriteLine(long.MaxValue);
            long n = Math.Abs(long.Parse(Console.ReadLine()));
                        
            int sumEven = 0;
            int sumOdd = 0;
            string direction = "";

            //FIRST SOLUTION - WITH ARRAY Of CHARS
            /*
            char[] digits = (Math.Abs(n)).ToString().ToCharArray();

            for (int i = 0; i < digits.Length; i++)
            {
                int digit = digits[i] - '0';
                if (digit % 2 == 0)
                {
                    sumEven += digit;
                }
                else
                {
                    sumOdd += digit;
                }
            }
             * */

            // SECOND SOLUTION WITH DIVISION BY 10
            
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

            if (sumEven > sumOdd)
            {
                direction = "right";
                Console.WriteLine("{0} {1}", direction, sumEven);
            }
            else if (sumEven < sumOdd)
            {
                direction = "left";
                Console.WriteLine("{0} {1}", direction, sumOdd);
            }
            else
            {
                direction = "straight";
                Console.WriteLine("{0} {1}", direction, sumEven);
            }
        }
}
