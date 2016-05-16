using System;
/*
Write methods to calculate  minimum ,  maximum ,  average ,  sum  and  product  of given set of integer
numbers. Use variable number of arguments. Write a program that reads  5  elements and prints their  
minimum ,  maximum ,  average ,  sum  and  product .

Input
•On the first line you will receive  5  numbers separated by spaces

Output
•Print their  minimum ,  maximum ,  average ,  sum  and  product  ◦Each on a new line
◦The  average  value should be printed with two digits of precision

Constraints
•Each of the five numbers will be in the interval  [ -1000, 1000 ] 
•Time limit: 0.1s
•Memory limit: 16MB
 
test
3 7 9 18 0 0
result :
18
7.40
37
0 

 * */
class IntegerCalculations
{
   static void Main()
   {
       string[] input = Console.ReadLine().Split();

       //read numbers
       int[] numbers = new int[input.Length];
       for (int i = 0; i < input.Length; i++)
			{
			 numbers[i] = int.Parse(input[i]);
			}
       //calculations
       int min = getMin(numbers);
       int max = getMax(numbers);
       double avg = getAverage(numbers);
       int sum = getSum(numbers);
       long product = getProduct(numbers);

       //output
       Console.WriteLine(min);
       Console.WriteLine(max);
       Console.WriteLine("{0:f2}",avg);
       Console.WriteLine(sum);
       Console.WriteLine(product);

   }

   static int getMin(params int[] numbers)
   {
       int min = 1000;
       for (int i = 0; i < numbers.Length; i++)
       {
           if (numbers[i] < min)
           {
               min = numbers[i];
           }
       }
       return min;
   }

   static int getMax(params int[] numbers)
   {
       int max = -1000;
       for (int i = 0; i < numbers.Length; i++)
       {
           if (numbers[i] > max)
           {
              max = numbers[i];
           }
       }
       return max;
   }

   static int getSum(params int[] numbers)
   {
       int sum = 0;
       for (int i = 0; i < numbers.Length; i++)
       {
           sum += numbers[i];
       }
       return sum;
   }

    static long getProduct(params int[] numbers)
   {
       long product = 1;
       for (int i = 0; i < numbers.Length; i++)
       {
           product *= numbers[i];
       }
       return product;
   }

    static double getAverage(params int[] numbers)
   {
       int count = numbers.Length;
       double avg = getSum(numbers) / (double)count;
       return avg;
   }
}
