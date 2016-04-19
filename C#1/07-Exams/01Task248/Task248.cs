using System;

class Task248
 {
        static void Main()
        {
            //TASK 248
            /*
            long  a = long.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());

            long r = 0;

            if (b == 2)
            {
                r = (a % c);
            }
            else if (b == 4)
            {
                r = (a + c);
            }
            else if (b == 8)
            {
                r = (a * c);
            }
            if (r % 4 == 0)
            {
                Console.WriteLine(r / 4);
            }
            else
            {
                Console.WriteLine(r % 4);
            }
            Console.WriteLine(r);
            */

            //TASK 349  with switch
            long a = long.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());

            long r = 0;

            switch (b)
            {
                case 3: r = a + c; break;
                case 6: r = a * c; break;
                case 9: r = a % c; break;
                default: Console.WriteLine("invalid input"); break;
            }

            
            if (r % 3 == 0)
            {
                Console.WriteLine(r / 3);
            }
            else
            {
                Console.WriteLine(r % 3);
            }
            Console.WriteLine(r);
        }
 }
