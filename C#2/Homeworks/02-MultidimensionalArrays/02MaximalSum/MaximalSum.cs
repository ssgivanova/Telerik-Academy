using System;
/*
 Write a program that reads a rectangular matrix of size  N x M  and finds in it the square  3 x 3  
 that has maximal sum of its elements. Print that sum.

Input
•On the first line you will receive the numbers N and M separated by a single space
•On the next N lines there will be M numbers separated with spaces - the elements of the matrix

Output
•Print the maximal sum of  3 x 3  square

Constraints
•3 <= N, M <= 1024
•Numbers in the matrix will be in the interval  [ -1000, 1000 ] 
•Time limit: 0.1s
•Memory limit: 16MB

 * */
class MaximalSum
{
   static void Main()
   {
       string[] inputNbrs = Console.ReadLine().Split();

       int n = int.Parse(inputNbrs[0]);
       int m = int.Parse(inputNbrs[1]);
       int[,] matrix = new int[n, m];
       int maxSum = Int32.MinValue;

       for (int i = 0; i < n; i++)
       {
           string[] rowElements = Console.ReadLine().Split();
           for (int j = 0; j < m; j++)
           {
               matrix[i, j] = int.Parse(rowElements[j]);
           }
       }

       //print matrix
       //for (int i = 0; i < n; i++)
       //{
       //    for (int j = 0; j < m; j++)
       //    {
       //        Console.Write(matrix[i, j] + " "); 
       //    }
       //    Console.WriteLine();
       //}

       int startRow = 0;
       int startCol = 0;

       //search for max sum
       for (int i = 0; i < n - 2; i++)
       {
           int currentSum = 0;
           for (int j = 0; j < m - 2; j++)
           {
               currentSum = matrix[i    , j] + matrix[i,     j + 1] + matrix[i,     j + 2] +
                            matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                            matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

               if (currentSum > maxSum)
               {
                   maxSum = currentSum;
                   startRow = i;
                   startCol = j;
               }
           }
       }
       Console.WriteLine(maxSum);

       //print maximal platform
       //for (int i = startRow; i < startRow + 3; i++)
       //{
       //    for (int j = startCol; j < startCol + 3; j++)
       //    {
       //        Console.Write(matrix[i,j] +" ");
       //    }
       //    Console.WriteLine();
       //}
   }
}
