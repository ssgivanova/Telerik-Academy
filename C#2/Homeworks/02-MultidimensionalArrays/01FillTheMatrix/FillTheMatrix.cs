using System;
/*
 Write a program that fills and prints a matrix of size  (n, n)  as shown below.

Input
•On the first line you will receive the number N
•On the second line you will receive a character ( a ,  b ,  c ,  d *) 
 which determines how to fill the matrix

Output
•Print the matrix ◦Numbers on a row must be separated by a single spacebar
◦Each row must be on a new line


Constraints
•1 <= N <= 128
•Time limit: 0.1s
•Memory limit: 16MB
*/
class FillTheMatrix
{
   static void Main()
   {
       int n = int.Parse(Console.ReadLine());
       char symbol = (char)Console.Read();
       
       int[,] matrix = new int[n, n];
       int number;

       //for case c & d
       int row = 0;
       int col = 0;

       switch (symbol)
       {
           case 'a':
               //fill matrix type 1 - fill vertically
               //1 5 9 13 
               //2 6 10 14 
               //3 7 11 15 
               //4 8 12 16 

               number = 1;
               //for (int i = 0; i < matrix.GetLength(0); i++)
               //{
               //    for (int j = 0; j < matrix.GetLength(1); j++)
               //    {
               //        //inverse i and j to fill the rows instead of columns
               //        matrix[j, i] = number;
               //        number++;
               //    }
               //}
               //iterate trough columns instead of rows int the outer loop - j counter for the cols, i for rows
               //for (int j = 0; j < matrix.GetLength(1); j++)
               //{
               //    for (int i = 0; i < matrix.GetLength(0); i++)
               //    {
               //        matrix[i, j] = number;
               //        number++;
               //    }
               //}
               for (int i = 0; i < n; i++)
               {
                   for (int j = 0; j < n; j++)
                   {
                       matrix[j, i] = number;
                       number++;
                   }
               }
               break;
           case 'b':
               //fill matrix type 2 - fill vertically up-down and down-up
               //1 8 9 16 
               //2 7 10 15 
               //3 6 11 14 
               //4 5 12 13 

               number = 1;
               //iterate trough columns instead of rows int the outer loop - j counter for the cols, i for rows
               for (int j = 0; j < n; j++) //cols
               {
                   //even 
                   if (j % 2 == 0)
                   {
                       for (int i = 0; i < n; i++) //rows
                       {
                           matrix[i, j] = number;
                           number++;
                       }
                   }
                   else
                   {
                       //odd 
                       for (int i = n-1; i >=0 ; i --) //rows
                       {
                           matrix[i, j] = number;
                           number++;
                       }
                   }
               }
               break;
           case 'c':
               //fill matrix type 3 - fill diagonally
               //7 11 14 16 
               //4 8 12 15 
               //2 5 9 13 
               //1 3 6 10 
 
               number = 1;
               /* first solution
               int maxElements = 0;
               
               for (int k = 0; k < (2 * n - 1); k++)
               {
                   if (k < n)
                   {
                       maxElements++;
                       row = n - k - 1;
                       col = 0;
                   }
                   else
                   {
                       maxElements--;
                       row = 0;
                       col = k - n + 1;
                   }
                   
                   for (int element = 0; element < maxElements; element++)
                   {
                       matrix[row, col] = number;
                       number++;
                       row++;
                       col++;
                   }
               } */
               
               //second solution
               //lower left side
               for (int i = n-1; i >= 0; i--)
               {
                   for (int j = 0; j < n-i-1; j++)
                   {
                       matrix[i+j, j] = number++;
                   }
               }

               //upper right side
               for (int i = 0; i < n-1; i++)
               {
                   for (int j = 1; j < n-i; j++)
                   {
                       matrix[j - 1, i + j] = number++;
                   }
               }

               break;
           case 'd':
               //fill matrix type 4 - spiral
               //1 12 11 10 
               //2 13 16 9 
               //3 14 15 8 
               //4 5 6 7 

               row = 0;
               col = 0;
               int maxRotations = n * n;
               string direction = "down";

               for (int i = 1; i <= maxRotations; i++)
               {
                   if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                   {
                       direction = "right";
                       row--;
                       col++;
                   }

                   if (direction == "right" && (col > (n - 1) || matrix[row, col] != 0))
                   {
                       direction = "up";
                       row--;
                       col--;
                   }

                   if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                   {
                       direction = "left";
                       row++;
                       col--;
                   }

                   if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                   {
                       direction = "down";
                       row++;
                       col++;
                   }

                   matrix[row, col] = i;

                   if (direction == "right")
                   {
                       col++;
                   }

                   if (direction == "down")
                   {
                       row++;
                   }

                   if (direction == "left")
                   {
                       col--;
                   }

                   if (direction == "up")
                   {
                       row--;
                   }
               }
               break;
           case 'e':
               //fill matrix type 5 - fill horizontally
               //1 2 3 4 
               //5 6 7 8 
               //9 10 11 12 
               //13 14 15 16  
               number = 1;
               for (int i = 0; i < n; i++)
               {
                   for (int j = 0; j < n; j++)
                   {
                       matrix[i, j] = number;
                       number++;
                   }
               }
               break;
           case 'f':
               //fill matrix type 5 - fill horizontally - from left to right
               //16 15 14 13 
               //12 11 10 9 
               //8 7 6 5 
               //4 3 2 1  
               number = 1;
               for (int i = matrix.GetLength(0)-1; i >= 0; i--)
               {
                   for (int j = matrix.GetLength(1)-1; j >=0; j--)
                   {
                       matrix[i, j] = number;
                       number++;
                   }
               }
               break;
           case 'g':
               //fill matrix type 2 - fill vertically down-up
               //4 8 12 16 
               //3 7 11 15 
               //2 6 10 14 
               //1 5 9 13 

               number = 1;
               //iterate trough columns instead of rows int the outer loop - j counter for the cols, i for rows
               for (int j = 0; j < matrix.GetLength(1); j++) //cols
               {
                   for (int i = matrix.GetLength(0) - 1; i >= 0; i--) //rows
                   {
                       matrix[i, j] = number;
                       number++;
                   }
               }
               break;
           default: Console.WriteLine("invalid symbol"); break;
       }

       

      // print matrix
       for (int i = 0; i < n; i++)
       {
           for (int j = 0; j < n; j++)
           {
               if (j < n - 1)
               {
                   Console.Write(matrix[i, j] + " ");
               }
               else
               {
                   Console.Write(matrix[i, j]);
               }
           }
           Console.WriteLine();
       }
   }
}
