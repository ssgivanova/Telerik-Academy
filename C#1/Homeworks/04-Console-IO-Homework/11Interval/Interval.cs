using System;

//Description
//•Write a program that reads two positive integer numbers N and M and prints how many numbers 
//exist between them such that the reminder of the division by 5 is 0.

//Input
//•On the first two lines you will receive two integers - N on the first and M on the second.

//Output
//•Output a single value - the amount of numbers divisible by 5 without remainder.

//Constraints
//•0 <= N <= M <= 2000
//•Time limit: 0.1s
//•Memory limit: 16MB
 

class Interval
 {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int count = 0;
            int max,min;

            if (n > m)
            {
                max = n;
                min = m;
            }
            else
            {
                max = m;
                min = n;
            }
            
            for (int i = min+1; i < max; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
}