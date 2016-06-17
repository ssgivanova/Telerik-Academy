namespace Generics
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            GenericList<int> intList = new GenericList<int>(8);
            intList.AddElement(5);
            intList.AddElement(4);
            intList.AddElement(28);
            intList.AddElement(44);
            intList.AddElement(0);

            Console.WriteLine(intList);
            Console.WriteLine(intList.Min());
            Console.WriteLine(intList.Max());

            intList.AddElement(500);
            Console.WriteLine(intList);

            intList.RemoveElement(1);
            Console.WriteLine(intList);

            intList.InsertElementAtPosition(12, 2);
            Console.WriteLine(intList);

            Console.WriteLine(intList.IndexOf(12));
            Console.WriteLine(intList.IndexOf(99));

        }
    }
}
