using System;
using System.Numerics;

class ConsoleApp1
{
    static void Main()
    {
        BigInteger firstTenProduct = 1;
        BigInteger lastProduct = 1;
        bool hasTenNumbers = false;

        string input = Console.ReadLine();
        int i = 0;
        //read input line by line
        while (!input.Equals("END"))
        {
            //calculate product of digits for every odd line
            if (i % 2 != 0)
            {
                BigInteger product = 1;
                //calculate product of digits of every number
                foreach (char symbol in input)
                {
                    //int digit = (int)Char.GetNumericValue(symbol);
                    int digit = symbol - '0';
                    if(digit != 0)
                    {
                        product *= digit;
                    }
                }
                //Console.WriteLine("prod " + product);
                if (i < 10)
                {
                    firstTenProduct *= product;
                }
                else
                {
                    //calculate the product for the position > 9 - lastProduct
                    hasTenNumbers = true;
                    lastProduct *= product;
                }

                //Console.WriteLine("i = {0}  product {1} - firstTen {2} next {3} ", i, product,allProduct,lastProduct);
            }

            i++;

            //read next line
            input = Console.ReadLine();
        }
        

        
        //output
        if (!hasTenNumbers)
        {
            Console.WriteLine(firstTenProduct);
        }
        else
        {
            Console.WriteLine(firstTenProduct);
            Console.WriteLine(lastProduct);
        }
        
       
       
        //lines = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            
       
    }
}
