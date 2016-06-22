namespace _06.DivisibleBy7And3
{
    using System;

    class DivisibleBy7And3
    {
        static void Main()
        {
            //Problem 6. Divisible by 7 and 3
            //Write a program that prints from given array of integers all numbers that are divisible
            //by 7 and 3. Use the built-in extension methods and lambda expressions. 
            //Rewrite the same with LINQ.

            int[] nums = new int[] { 1, 3, 7, 21, 18, 12,42 };
            var divisibleNums = nums.DivisibleBy3And7Link();
            //var divisibleNums = nums.DivisibleBy3And7();
            foreach (var n in divisibleNums)
            {
                Console.Write(n +" ");
            }
        }
    }
}
