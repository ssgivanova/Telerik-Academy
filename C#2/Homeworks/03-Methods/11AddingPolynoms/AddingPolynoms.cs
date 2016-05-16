using System;
/*
Write a method that adds two polynomials. Represent them as arrays of their coefficients. Write a program that reads two polynomials and prints their sum.

Input
•On the first line you will receive the number N
•On the second line you will receive the first polynomial as coefficients separated by spaces
•On the third line you will receive the second polynomial as coefficients separated by spaces

Output
•Print the sum of the polynomials

Constraints
•1 <= N <= 1024
•Time limit: 0.1s
•Memory limit: 16MB
 * 
3
5 0 1
7 4 -3
result -> 12 4 -2

Example explanation:
x2 + 5 =  1 x2 +  0 x +  5  => { 5 ,  0 ,  1 }
-3x2 + 4x + 7 =  -3 x2 +  4 x +  7  => { 7 ,  4 ,  -3 }
(x2 + 5) + (-3x2 + 4x + 7) = (-2x2 + 4x + 12) =  -2 x2 +  4 x +  12  => { 12 ,  4 ,  -2 }

 */ 
class AddingPolynoms
{
   static void Main()
    {
       int n = int.Parse(Console.ReadLine());
       int[] p1 = new int[n];
       int[] p2 = new int[n];
       int[] sum = new int[n];

       //read numbers
       //first polynom
       string[] line = Console.ReadLine().Split();
       for (int i = 0; i < n; i++)
       {
           p1[i] = int.Parse(line[i]);
       }
       //second polynom
       line = Console.ReadLine().Split();
       for (int i = 0; i < n; i++)
       {
           p2[i] = int.Parse(line[i]);
       }

       //process arrays and calculate sum
       sum = AddPolynoms(p1,p2);

       //print sum array
       PrintArray(sum);
    }

   static int[] AddPolynoms(int[] p1, int[] p2)
   {
       int[] sum = new int[p1.Length];
       for (int i = 0; i < sum.Length; i++)
       {
           sum[i] = p1[i] + p2[i];
       }
       return sum;
   }

   static void PrintArray(int[] arr)
   {
       foreach (int item in arr)
       {
           Console.Write(item + " ");
       }
   }
}
