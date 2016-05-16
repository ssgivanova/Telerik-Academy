using System;
/*
Write a method that adds two positive integer numbers represented as arrays of digits 
(each array element  arr[i]  contains a digit; the last digit is kept in  arr[0] ). 
Write a program that reads two arrays representing positive integers and outputs their sum.

Input
•On the first line you will receive two numbers separated by spaces - the size of each array
•On the second line you will receive the first array
•On the third line you will receive the second array

Output
•Print the sum as an array of digits (as described) ◦Digits should be separated by spaces


Constraints
•Each of the numbers that will be added could have up to  10 000  digits.
•Time limit: 0.1s
•Memory limit: 16MB
 * 
3 4
8 3 3
6 2 4 2  
result -> 4 6 7 2 
 
 * */
class NumberAsArray
{
   static void Main()
   {
       string[] nbrElements = Console.ReadLine().Split();
       int n1 = int.Parse(nbrElements[0]);
       int n2 = int.Parse(nbrElements[1]);

       int[] arr1 = new int[n1];
       int[] arr2 = new int[n2];

       //read numbers
       //first array
       string[] numbers = Console.ReadLine().Split();
       for (int i = 0; i < arr1.Length; i++)
       {
           arr1[i] = int.Parse(numbers[i]);
       }
       //second array
       numbers = Console.ReadLine().Split();
       for (int i = 0; i < arr2.Length; i++)
       {
           arr2[i] = int.Parse(numbers[i]);
       }

       //the final array where the corresponding elements of the 2 arrays will be summed
       int[] sum = SumTwoArraysElements(arr1, arr2);

       //print resulting array
       PrintArray(sum);
   }

   static int[] SumTwoArraysElements(int[] arr1, int[] arr2)
   {
       //get arrays with most elements
       int minLength = Math.Min(arr1.Length, arr2.Length);
       int maxLength = Math.Max(arr1.Length, arr2.Length);

       int[] sum = new int[maxLength]; // the final array

       //process array
       bool overTen = false;
       for (int i = 0; i < maxLength; i++)
       {
           if (i < minLength) //iterate over the smaller length and calculate the sum of the elements
           {
               sum[i] = arr1[i] + arr2[i]; //2+5 ->7  
               if (overTen)                //9+5=14 -> 4 and 1 for the next
               {
                   sum[i]++;
                   overTen = false;
               }

               if (sum[i] > 9)
               {
                   sum[i] = sum[i] % 10;
                   overTen = true;
               }
           }
           else
           {
                              //copy the remainding elements from the other array
               if (arr1.Length > arr2.Length)
               {
                   sum[i] = arr1[i];
               }
               else
               {
                   sum[i] = arr2[i];
               }

               if (overTen)
               {
                   sum[i]++;
                   overTen = false;
               }

               if (sum[i] > 9)
               {
                   sum[i] = sum[i] % 10;
                   overTen = true;
               }
           }
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
