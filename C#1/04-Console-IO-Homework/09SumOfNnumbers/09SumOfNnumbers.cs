using System;
using System.Threading;
using System.Globalization;

//Write a program that enters a number N and after that enters more N numbers and calculates 
//and prints their sum.


//Input
//•On the first line, you will receive the number N
//•On each of the next N lines, you will receive a floating-point number

//Output
//•On must output only one number - the sum of the N numbers

//•1 <= N <= 200
//•All numbers will be valid floating-point numbers in the range  [-1000, 1000] 



class Program
 {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            float sum = 0;

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                float num = float.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine(sum);

        }
 }
