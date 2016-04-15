using System;

//Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.
//•Use the Euclidean algorithm (find it in Internet).

//Input
//•On the first and only line of the input you will receive the 2 integers A and B, separated by 
//a whitespace.

//Output
//•Output a single number - the GCD of the numbers A and B.

//Constraints
//•The numbers A and B will always be valid integers in the range  [2, 500] .

//ex : (1071, 462) - > gcd = 21

 class GreatestCommonDivisor
 {
    static void Main()
    {
        string[] nums = Console.ReadLine().Split(' ');
        int a = int.Parse(nums[0]);
        int b = int.Parse(nums[1]);

        int gcd = 0;
        int remainder = 0;
        
        //first solution - by division
        while (b != 0)
        {
            remainder = a % b;
            a = b;
            b = remainder;
            //Console.WriteLine("{0}, {1}, rem {2}", a, b, remainder);
        }
        gcd = a;
        Console.WriteLine(gcd);

        //second solution - with substraction
        //while (a != b)
        //{
        //    if (a > b)
        //    {
        //        a = a - b;
        //    }
        //    else
        //    {
        //        b = b - a;
        //    }
        //    //Console.WriteLine("{0}, {1}", a, b);
        //}
        //gcd = a;
        //Console.WriteLine(gcd);

    }
}
