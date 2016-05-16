using System;
class Matrix
{
   static void Main()
   {
       string[] inputNbrs = Console.ReadLine().Split();

       int n = int.Parse(inputNbrs[0]);
       int m = int.Parse(inputNbrs[0]);
       int[,] matrix = new int[n, m];

       for (int i = 0; i < n; i++)
       {
           string[] rowElements = Console.ReadLine().Split();
           for (int j = 0; j < m; j++)
           {
               matrix[i, j] = int.Parse(rowElements[j]);
           }
       }
       int diagonalCount = 1;
       int maxDiagonalCount = 1;
       //print diagonals
       
       for (int i = 0; i < n-1; i++)
       {
           for (int j = 0; j < m; j++)
           {
               //if (i == j) //first diagonal 0,0 1,1 2,2
               //{
               //    //Console.Write(matrix[i, j] + " ");
               //    if (matrix[i, j] == matrix[i + 1, j + 1])
               //    {
               //        diagonalCount++;
               //    }
               //    else
               //    {
               //        diagonalCount = 1;
               //    }
               //    if (diagonalCount > maxDiagonalCount)
               //    {
               //        maxDiagonalCount = diagonalCount;
               //    }
               //}
               if (i == n - j - 1) //second diagonal 0,4 1,3 2,2 3,1 4,0
               {
                   if (matrix[i, j] == matrix[i + 1, j - 1])
                   {
                       diagonalCount++;
                   }
                   else
                   {
                       diagonalCount = 1;
                   }
                   if (diagonalCount > maxDiagonalCount)
                   {
                       maxDiagonalCount = diagonalCount;
                   }
               } 
           }
       }
       Console.WriteLine(maxDiagonalCount);
        

       int colSequence = 1;
       int maxColSequence = 1;
       //columns
       for (int i = 0; i < matrix.GetLength(0); i++)
       {
           colSequence = 1;
           for (int j = 0; j < matrix.GetLength(0) - 1; j++)
           {
               if (matrix[i, j] == matrix[i, j + 1])
               {
                   colSequence++;
               }
               else
               {
                   colSequence = 1;
               }
               if (colSequence > maxColSequence)
               {
                   maxColSequence = colSequence;
               }
           }
       }
       Console.WriteLine(maxColSequence);
       int rowSequence = 1;
       int maxRowSequence = 1;
       //rows
       //columns
       for (int i = 0; i < matrix.GetLength(0) -1; i++)
       {
           for (int j = 0; j < matrix.GetLength(0); j++)
           {
               if (matrix[i, j] == matrix[i +1, j])
               {
                   Console.Write(matrix[i, j] +" ");
                   rowSequence++;
               }
               else
               {
                   rowSequence = 1;
               }
               if (rowSequence > maxRowSequence)
               {
                   maxRowSequence = rowSequence;
               }
           }
       }
   }
}
