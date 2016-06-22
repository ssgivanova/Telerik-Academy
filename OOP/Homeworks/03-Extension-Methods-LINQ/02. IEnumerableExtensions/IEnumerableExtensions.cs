namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        //Implement a set of extension methods for IEnumerable<T> that implement the following group 
        //functions: sum, product, min, max, average.

        public static T Sum<T>(this IEnumerable<T> list) where T:struct,IComparable,IConvertible
        {
           if (list.Count() <= 0)
           {
                throw new ArgumentException("There's no elements in the collection to calculate");
           }

          T sum = (dynamic)0;
          foreach (var item in list)
          {
              sum += (dynamic)item;
          }
          return sum;
        }

        public static T Product<T>(this IEnumerable<T> list) where T : struct,IComparable, IConvertible
        {
            if (list.Count() <= 0)
            {
                throw new ArgumentException("There's no elements in the collection to calculate");
            }
            T product = (dynamic)1;
            foreach (var item in list)
            {
                product *=(dynamic)item;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> list) where T : struct,IComparable, IConvertible
        {
            if (list.Count() <= 0)
            {
                throw new ArgumentException("There's no elements in the collection to calculate");
            }
            if (list.Count() == 0)
            {
                throw new ArgumentException("There's no elements in the collection to calculate");
            }
            return list.Min(x => x);
        }

        public static T Max<T>(this IEnumerable<T> list) where T : struct,IComparable, IConvertible
        {
            if (list.Count() == 0)
            {
                throw new ArgumentException("There's no elements in the collection to calculate");
            }
            return list.Max(x => x);
        }

        public static double Average<T>(this IEnumerable<T> list) where T : struct,IComparable, IConvertible
        {
            if (list.Count() == 0)
            {
                throw new ArgumentException("There's no elements in the collection to calculate");
            }
            return (dynamic)list.Sum() / (dynamic)list.Count();

            
        }
    }
}
