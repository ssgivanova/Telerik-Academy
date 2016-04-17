using System;

class SaddyKopper
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //int n = 12345;
            
            int value = 0;
            int sum = 0;
            int prod = 1;
            int countTransformation = 0;
            int result = 0;

            do
            {
                //remove last digit
                value = n / 10;
                
                //Console.WriteLine(n);
                //find all digits at even position and find their sum
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
                prod *= sum;
                //product became new number end check if it has more than 1 digit
                
                
            }//while no digits left
            while (n > 1);
            countTransformation++;
            Console.WriteLine("prod {0}", prod);

            if (prod / 10 == 0)
            {
                result = prod;
            }
            else 
            {
                n = prod;
                prod = 1;
                while (n > 1)
                {
                    value = prod / 10;
                    n = value;
                    if (countTransformation >= 10) { break; }
                    
                }
                result = prod;
                countTransformation++;
            }
            
            Console.WriteLine("prod {0}", prod);
            Console.WriteLine("transformations {0}", countTransformation);
            Console.WriteLine("result {0}",result);

            Console.WriteLine();

            //print output
            if (countTransformation < 10)
            {
                Console.WriteLine("{0}\n{1}", countTransformation, result);
            }
            else
            {
                Console.WriteLine(result);
            }
            
        }
    }
