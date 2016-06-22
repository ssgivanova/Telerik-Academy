using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.LongestString
{
    class Startup
    {
        static void Main()
        {
            //Write a program to return the string with maximum length from an array of strings.Use LINQ.

            string[] words = new string[] { "hello", "dog", "alphabet", "house" };
            List<string> wordsList = words.ToList<string>();

            var longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();

            //another solution
            //var longestWord = words.FirstOrDefault(w => w.Length == words.Max(y => y.Length));
            Console.WriteLine(longestWord);
        }
    }
}
