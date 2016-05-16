using System;
/*
We are given a matrix of strings of size  N x M . 
Sequences in the matrix we define as sets of several neighbour elements located on the same line, 
column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix
and prints its length.

Input
•On the first line you will receive the numbers N and M separated by a single space
•On the next N lines there will be M strings separated with spaces - the strings in the matrix

Output
•Print the length of the longest sequence of equal equal strings in the matrix

Constraints
•3 <= N, M <= 128
•Time limit: 0.1s
•Memory limit: 16MB

 */
class SequenceInMatrix
{
    static void Main()
    {
        int rowSequence = 1;
        int colSequence = 1;
        int diagonalSequence = 1;

        int maxRowSequence = 1;
        int maxColSequence = 1;
        int maxDiagonal1Sequence = 1;
        int maxDiagonal2Sequence = 1;
        int maxSequence = 1;

        string[] inputNbrs = Console.ReadLine().Split();

        int n = int.Parse(inputNbrs[0]);
        int m = int.Parse(inputNbrs[1]);
        string[,] matrix = new string[n, m];

        //read matrix
        for (int i = 0; i < n; i++)
        {
            string[] rowElements = Console.ReadLine().Split();
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = rowElements[j];
            }
        }

        //counting column sequences
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            colSequence = 1;
            for (int j = 0; j < matrix.GetLength(0)-1; j++)
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
        
        //counting row sequences
        for (int j = 0; j < matrix.GetLength(0); j++) //cols
        {
            for (int i = 0; i < matrix.GetLength(1)-1; i++) //rows
            {
                if (matrix[i, j] == matrix[i+1, j])
                {
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
        

        /*
        //counting diagonal sequences
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < m - 1; j++)
            {
                if (i == j) //first diagonal
                {
                    if (matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        diagonalSequence++;
                    }
                    else
                    {
                        diagonalSequence = 1;
                    }
                    if (diagonalSequence > maxDiagonalSequence)
                    {
                        maxDiagonalSequence = diagonalSequence;
                    }
                }
            }
        }
         */

        //find equals elements on same diagonal
        /////////
        int row = 0;
        int col = 0;
        int maxElements = 0;

        n = matrix.GetLength(0) + matrix.GetLength(1) - 1;

        for (int k = 0; k < (2 * n - 1); k++)
        {
            if (k < matrix.GetLength(1))
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

            for (int element = 0; element < maxElements - 1; element++)
            {
                //matrix[row, col] = number;
                //number++;
                //row++;
                //col++;
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    diagonalSequence++;
                }
                else
                {
                    diagonalSequence = 1;
                }
                if (diagonalSequence > maxDiagonal1Sequence)
                {
                    maxDiagonal1Sequence = diagonalSequence;
                }
                row++;
                col++;
            }
        }
        
        /////////
        maxElements = 0;
        for (int k = 0; k < (2 * n - 1); k++)
        {
            if (k < matrix.GetLength(0))
            {
                maxElements++;
                col = k;
                row = 0;
            }
            else
            {
                maxElements--;
                col = n - 1;
                row = k - n + 1;
            }

            for (int element = 0; element < maxElements - 1; element++)
            {
                //matrix[row, col] = number;
                //number++;
                //row++;
                //col++;
                if (matrix[row, col] == matrix[row + 1, col - 1])
                {
                    diagonalSequence++;
                }
                else
                {
                    diagonalSequence = 1;
                }
                if (diagonalSequence > maxDiagonal2Sequence)
                {
                    maxDiagonal2Sequence = diagonalSequence;
                }
                row++;
                col--;
            }
        }
        //////////
        maxSequence = Math.Max(Math.Max(maxRowSequence, maxColSequence), Math.Max(maxDiagonal1Sequence, maxDiagonal2Sequence));

        //Console.WriteLine("col "+maxColSequence);
        //Console.WriteLine("row " + maxRowSequence);
        //Console.WriteLine("diagonal " + maxDiagonalSequence);
        //Console.WriteLine("max " + maxSequence);
        Console.WriteLine(maxSequence);
    }
}
