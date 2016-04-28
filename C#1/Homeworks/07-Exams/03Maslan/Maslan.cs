using System;
using System.Numerics;
class Maslan
{
        static void Main()
        {
            // FIRST SOLUTION - WITH TWO WHILE LOOP AND DIVISION BY 10
            // CORRECT BUT TOO SLOW FOR BIG INPUT NUMBERS AT BGCODER - EXCEEDS TIME LIMIT
            /*
            BigInteger n = long.Parse(Console.ReadLine());
            
            long sum = 0;
            BigInteger prod = 1;
            int digit = 0;
            int transformationCount = 0;
            BigInteger result = 0;

            //while transformation < 10 and product has more than 1 digit -  [0 - 9]
            while (transformationCount < 10 || n > 10)
            {

                prod = 1;
                //remove last digit, calculate sum of digits and product
                //until no digits left
                while (n > 1)
                {
                    //get the number without last digit as string
                    n = n / 10;
                    string newNumber = n.ToString();
                    
                    //initialize with 0 and 1 at the beginning ofbevery new number calculation
                    sum = 0;
                    
                    // get the sum of all the odd digits, k - position of the symbol in the string
                    int k = 0; 
                    foreach (char symbol in newNumber)
                    {
                        //int digit = symbol - '0';
                        digit = (int)Char.GetNumericValue(symbol);

                        if (k % 2 != 0)
                        {
                            sum += digit;
                        }
                        k++;
                    }

                    if (sum != 0)
                    {
                        prod *= (ulong)sum;
                    }
                   //Console.WriteLine("n={0} sum = {1} prod = {2}", n, sum, prod);
                    
                }
                transformationCount++;
                result = prod;

                if (prod >= 10)
                {
                    n = prod;
                    //Console.WriteLine(" --> start new transformation : n = {0}", n);
                }
                else
                {
                    result = prod;
                    break;
                }
            }
            
            //Console.WriteLine("transformations " + transformationCount);

            //Console.WriteLine("--------------output --------------");
            if (transformationCount < 10)
            {
                Console.WriteLine(transformationCount);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result);
            }
             * */

            //SECOND SOLUTION - WITH STRING AND SUBSTRING


            string text  = Console.ReadLine();

            long sum = 0;
            BigInteger prod = 1;
            int digit = 0;
            int transformationCount = 0;
            BigInteger result = 0;

            //while we have more than 1 symbol = more than 1 digits for the product
            while (text.Length > 1)
            {
                text = text.Substring(0, text.Length - 1);
                //calculate sum of digits at odd position and their product for every new number 
                //with last digit removed
                int i = 0;
                sum = 0;
                prod = 1;
                foreach (char symbol in text)
                {
                    if (i % 2 != 0)
                    {
                        digit = symbol - '0';
                        sum += digit;
                    }
                    
                    if (sum != 0)
                    {
                        prod *= sum;
                    }

                    i++;
                }
                
                transformationCount++;
                //result after one transformation
                Console.WriteLine("n={0} sum = {1} prod = {2}", text, sum, prod);

                //the product become the new text (number)
                //if the text has > 1 symbol (digit) - start the calculation again, 
                //otherwise quite the while loop 
                text = prod.ToString();

                if (transformationCount == 10)
                {
                    break;
                }
            }

            //print output
            if (transformationCount < 10)
            {
                Console.WriteLine(transformationCount);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine(text);
            }
        }
}
