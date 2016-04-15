using System;

//You are given N integers (given in a single line, separated by a space).
//•Write a program that checks whether the product of the odd elements is equal to the product 
//of the even elements.
//•Elements are counted from 1 to N, so the first element is odd, the second is even, etc.

//Input
//•On the first line you will receive the number N
//•On the second line you will receive N numbers separated by a whitespace

//Output
//•If the two products are equal, output a string in the format "yes PRODUCT_VALUE", 
//otherwise write on the console "no ODD_PRODUCT_VALUE EVEN_PRODUCT_VALUE"

//Constraints
//•N will always be a valid integer number in the range  [4, 50] 
//•All input numbers from the second line will also be valid integers


class OddAndEvenProduct
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int productOdd = 1;
        int productEven = 1;
        bool isProductEqual = false;

        string[] numbers = (Console.ReadLine()).Split(' ');

        for (int i = 0; i < n; i+=2)
        {
            int num = int.Parse(numbers[i]);
            productOdd *= num;
            //Console.Write("{0}*",num);
        }
        //Console.WriteLine("odd={0}", productOdd);
        for (int j = 1; j < n-1; j += 2)
        {
            int num = int.Parse(numbers[j]);
            productEven *= num;
            //Console.Write("{0}*", num);
        }
        //Console.WriteLine("even={0}", productEven);

        isProductEqual = (productOdd == productEven) ? true : false;

        if (isProductEqual)
        {
            Console.WriteLine("yes {0}", productEven);
        }
        else
        {
            Console.WriteLine("no {0} {1}", productOdd, productEven);
        }

    }
}
