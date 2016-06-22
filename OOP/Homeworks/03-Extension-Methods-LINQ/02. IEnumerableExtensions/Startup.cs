namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Startup
    {
        static void Main()
        {
            //Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
            //List<int> myList = new List<int>() { 1, 2, 3, 4, 5 };
            List<double> myList = new List<double>() { 2.5, 2.5, 1, 4, 5.3 };
            Console.WriteLine(myList.Sum());
            Console.WriteLine(myList.Product());
            Console.WriteLine(myList.Average());
            Console.WriteLine(myList.Min());
            Console.WriteLine(myList.Max());
        }
    }
}
