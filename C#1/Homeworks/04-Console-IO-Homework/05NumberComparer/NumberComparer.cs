using System;

//Write a program that gets two numbers from the console and prints the greater of them.

//Input
//•On the first two lines you will receive the two numbers, A and B

//Output
//•On the only line print the larger of the two numbers ◦*Try implementing it without using if-statements



class NumberComparer
{
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());

            float greater = a > b ? a : b;

            float greaterNumber = Math.Max(a, b);
            Console.WriteLine(greaterNumber);

            //Console.WriteLine(greater);
        }
}
