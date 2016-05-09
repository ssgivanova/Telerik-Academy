using System;

//Write a program that allocates array of N integers, initializes each element by its index multiplied 
//by  5  and the prints the obtained array on the console
//Constraints
//•1 <= N <= 20
//•N will always be a valid integer number
//•Time limit: 0.1s
//•Memory limit: 16MB


class AllocateAray
    {
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            while (n < 1 || n > 20)
            {
                Console.WriteLine("enter n : [1,20] ");
                n = int.Parse(Console.ReadLine());
            }

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
            }

            //print output
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
