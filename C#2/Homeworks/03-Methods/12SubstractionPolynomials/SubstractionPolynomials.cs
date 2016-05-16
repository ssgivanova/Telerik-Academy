using System;
/*Extend the previous program to support also subtraction and multiplication of polynomials.*/
 
class SubstractionPolynomials
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] p1 = new int[n];
        int[] p2 = new int[n];
        int[] result = new int[n];

        //read numbers
        //first polynom
        string[] line = Console.ReadLine().Split();
        for (int i = 0; i < n; i++)
        {
            p1[i] = int.Parse(line[i]);
        }
        //second polynom
        line = Console.ReadLine().Split();
        for (int i = 0; i < n; i++)
        {
            p2[i] = int.Parse(line[i]);
        }

        Console.WriteLine("\nPolynomials Addition");
        result = AddPolynoms(p1, p2);
        PrintArray(result);

        Console.WriteLine("\nPolynomials Substraction");
        result = SubstractPolynoms(p1, p2);
        PrintArray(result);

        Console.WriteLine("\nPolynomials Multiplication");
        result = MultiplyPolynoms(p1, p2);
        PrintArray(result);
    }

    static int[] AddPolynoms(int[] p1, int[] p2)
    {
        int[] sum = new int[p1.Length];
        for (int i = 0; i < sum.Length; i++)
        {
            sum[i] = p1[i] + p2[i];
        }
        return sum;
    }

    static int[] SubstractPolynoms(int[] p1, int[] p2)
    {
        int[] substract = new int[p1.Length];
        for (int i = 0; i < substract.Length; i++)
        {
            substract[i] = p1[i] - p2[i];
        }
        return substract;
    }

    static int[] MultiplyPolynoms(int[] p1, int[] p2)
    {
        int[] multiply = new int[p1.Length];
        for (int i = 0; i < multiply.Length; i++)
        {
            multiply[i] = p1[i] * p2[i];
        }
        return multiply;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
    }
}
