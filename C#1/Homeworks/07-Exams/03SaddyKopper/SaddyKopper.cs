using System;
using System.Numerics;

class SaddyKopper
    {
        static void Main()
        {

            BigInteger n = BigInteger.Parse(Console.ReadLine());

            //BigInteger n = 12345;

            BigInteger value = 0;
            BigInteger sum = 0;
            BigInteger prod = 1;
            int countTransformation = 0;
            //BigInteger result = 0;

            do
            {
                prod = 1;
                do
                {
                    //remove last digit
                    //Step 2
                    value = n / 10;
                
                    //Console.WriteLine(n);
                    //find all digits at even position and find their sum
                    //Step 3
                    sum = 0;
                    string numStr = value.ToString();
                    for (int i = 0; i < numStr.Length; i+=2)
                    {
                        sum += (int)Char.GetNumericValue(numStr[i]);
                    }
                    Console.WriteLine("n = {0} - sum {1}", value, sum);
                
                    //divide again to obtain new number with removed last digit 
                    n = value;

                    //get the product of all sums found
                    //Step 5
                    prod *= sum;
                    
                    Console.WriteLine("prod = {0}", prod);
                }while(n > 9); //Step 4
                //product became new number end check if it has more than 1 digit
                //Step 6
                n = prod;
                countTransformation++;
                //Console.WriteLine("countTransformation = {0}", countTransformation);
                //Step 7 - has only one digit
                if (n < 10)
                {
                    break;
                }
            } while (countTransformation < 10); //Step 8

            //Step 9
            //result = n;
            if (countTransformation < 10)
            {
                Console.WriteLine("{0}\n{1}", countTransformation, n);
            }
            else
            {
                Console.WriteLine(n);
            }
        }
    }
