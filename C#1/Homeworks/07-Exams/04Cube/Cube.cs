using System;
class Cube
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //int n = 8;

        int w = 2 * n - 1;
        int topSide = n - 2;

        //the top
        Console.Write(new String(' ', n));
        Console.Write(new String(':', n));
        Console.WriteLine();

        //print top side
        for (int i = 0; i < n-2; i++)
        {
            Console.Write(new String(' ', n-i-1));
            Console.Write(":");
            if (i < n - 2)
            {
                Console.Write(new String('/', n - 2));
                Console.Write(":");
            }
            
            //print side
            Console.Write(new String('X', i));
            Console.Write(":");
            Console.WriteLine();
        }
               
        //print front
        for (int i = 0; i < n; i++)
        {
            if (i == n-1 || i == 0)
            {
                Console.Write(new String(':', n));
            }
            else
            {
                Console.Write(":");
                Console.Write(new String(' ', n - 2));
                Console.Write(":");
            }
            //print side,avoid negative count
            if (n - 2 - i >= 0)
            {
                Console.Write(new String('X', n - 2 - i));
                Console.Write(":");
            }
            
            Console.WriteLine();
        }
    }
}
