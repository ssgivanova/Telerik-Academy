namespace _06.DivisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ArrayExtensions
    {
        public static int[] DivisibleBy3And7Link(this int[] numbers)
        {
            var divisibleNums = numbers.Where(n => n % 7 == 0 && n % 3 == 0).ToArray();
            return divisibleNums;
        }

        public static int[] DivisibleBy3And7(this int[] numbers)
        {
            var divisibleNums = from num in numbers
                                where num % 7 == 0 && num % 3 == 0
                                select num;
            return divisibleNums.ToArray();
        }
    }
}
