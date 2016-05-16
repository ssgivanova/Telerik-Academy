
/*
 Write a program, that reads from the console an array of  N  integers and an integer  K , 
 sorts the array and using the method  Array.BinSearch()  finds the largest number in the array 
 which is ≤  K . 
 * */
namespace _04BinarySearch
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class NumbersComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x.CompareTo(y);
        }
    }

    class BinarySearch
    {
        static void Main()
        {
            //binary search in array
            Console.Write("Enter an integer number for the length of the array N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter an integer number K: ");
            int k = int.Parse(Console.ReadLine());

            //the array is one element bigger than the needed numbers
            //the last elements is the searched number K
            int[] array = new int[n + 1];
            Console.WriteLine("Enter {0} numbers to array:", n);
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            array[n] = k;

            Array.Sort(array);

            /*BinarySearch() returns the index of the specified value in the specified array, if value is found. 
            If value is not found and value is less than one or more elements in array, a negative number 
            which is the bitwise complement of the index of the first element that is larger than value. 
            (the index of the last element plus 1).*/
            int indexK = Array.BinarySearch(array, k);

            if (indexK == 0)
            {
                Console.WriteLine(
                    "\nNo smaller or equal to K = {0} number in the array", k);
            }
            else
            {
                //the number before the last number (k) if k doesn't exist in the array
                //or the number before the numbe equal to k if it exists
                Console.WriteLine("\nThe largest number in the array which is <= {0} is: {1}", k, array[indexK - 1]);
            }

            //binary search in array with Comparer
            Console.WriteLine("Enter numbers, separated by a comma: ");
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .OrderBy(x => x)
                .ToList();

            Console.Write("Enter number K: ");
            k = int.Parse(Console.ReadLine());
            
            /*
            NumberComparer comparer = new NumberComparer();
            int index = array.BinarySearch(k, comparer);

            if (index >= 0)
                Console.WriteLine(array[index]);
            else
            {
                index = Math.Abs(index) - 2;
                if (index >= 0)
                    Console.WriteLine(array[index]);
                else
                    Console.WriteLine("No numbers less than/equal to {0} were found!", k);
            }
             */
        }
    }
}
