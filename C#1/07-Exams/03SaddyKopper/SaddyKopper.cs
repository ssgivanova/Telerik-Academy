using System;

class SaddyKopper
    {
        static void Main()
        {
            //int n = int.Parse(Console.ReadLine());

            int n = 12345;
            
            bool hasMoreDigits = true;
            int value = 0;
            int sum = 0;
            int prod = 1;
            int countTransformation = 0;
            int result = 0;

            //int value = n / (int)(Math.Pow(10,nbrDigits-1));
            //Console.WriteLine(value);

            do
            {
                value = n / 10;
                
                //Console.WriteLine(n);
                sum = 0;
                string numStr = value.ToString();
                for (int i = 0; i < numStr.Length; i+=2)
                {
                     sum += (int)Char.GetNumericValue(numStr[i]);
                }
                Console.WriteLine("n = {0} - sum {1}", value, sum);
                prod *= sum;

                //divide again
                n = value;

                //Console.WriteLine("prod {0}",prod);
                //if (prod / 10 == 0)
                //{
                    //hasMoreDigits = false;
                    countTransformation++;
                    result = prod;
                //    break;
                //}
                //else
                //{
                //    n = prod;
                //}
            }
            while (n > 1);
            Console.WriteLine("prod {0}", prod);
            Console.WriteLine("transformations {0}", countTransformation);
            Console.WriteLine("result {0}",result);
        }
    }
