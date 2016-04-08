using System;

//Write a program that reads an integer N (which will always be less than 100 or equal) 
//and uses an expression to check if given N is prime (i.e. it is divisible without remainder only 
//to itself and 1).
//Note: You should check if the number is positive

//input : N

//output : true if the number is prime and false otherwise. 


class PrimeCheck
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (n == 1 || n <= 0 )
            {
                isPrime = false;
            }
            else 
            {
                for (int i = 2; i <n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        isPrime = true;
                    }

                }
            }

            Console.WriteLine(isPrime.ToString().ToLower());

        }
}