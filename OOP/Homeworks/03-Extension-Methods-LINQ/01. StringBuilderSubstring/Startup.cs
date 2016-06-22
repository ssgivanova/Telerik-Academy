namespace _01.StringBuilderSubstring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Startup
    {
        static void Main()
        {
            //test the method
            StringBuilder sb = new StringBuilder();
            sb.Append("assddfdgfhgjhjkkjkl");

            StringBuilder substringed = sb.Substring(1, 3);
            Console.WriteLine(substringed);
        }
    }
}
