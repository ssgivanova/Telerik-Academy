using System;
class Program
{
   static void Main()
   {
       int n = int.Parse(Console.ReadLine());

       int[,] matrix = new int[n, n];
       int number = 1;

       //7 11 14 16 
       //4 8 12 15 
       //2 5 9 13 
       //1 3 6 10 

       //for (int i = n-1; i >= 0; i--)
       //{
       //    for (int j = 0; j <=n-1; j++)
       //    {
       //        matrix[i, j] = number;
       //        number++;
       //    }
       //    Console.WriteLine();
       //}

       /*
       int maxElements = 0;
       int row = 0;
       int col = 0;

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
               col = k- n + 1;
           }

           for (int element = 0; element < maxElements; element++)
           {
               matrix[row, col] = number;
               number++;
               row++;
               col++;
           }
       }



       Console.WriteLine();

       for (int i = 0; i < n; i++)
       {
           for (int j = 0; j < n; j++)
           {
               Console.Write(matrix[i, j] + " ");
           }
           Console.WriteLine();
       }
        */ 

       Console.WriteLine();
       //spiral matrix
       int row = 0;
       int col = 0;
       int maxRotations = n * n;
       string direction = "right";

       for (int i = 1; i <= maxRotations; i++)
       {
           if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
           {
               direction = "down";
               row++;
               col--;
           }

           if (direction == "down" && (row > (n - 1) || matrix[row, col] != 0))
           {
               direction = "left";
               row--;
               col--;
           }

           if (direction == "left" && (col < 0 || matrix[row, col] != 0))
           {
               direction = "up";
               row--;
               col++;
           }

           if (direction == "up" && (row < 0 || matrix[row, col] != 0))
           {
               direction = "right";
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

       for (int i = 0; i < n; i++)
       {
           for (int j = 0; j < n; j++)
           {
               Console.Write(matrix[i, j] + " ");
           }
           Console.WriteLine();
       }


   }
}
