using System;
using System.Collections.Generic;
using System.Linq;

/*
Write a program that finds the largest area of equal neighbour elements in a rectangular matrix 
and prints its size.

Input
•On the first line you will receive the numbers N and M separated by a single space
•On the next N lines there will be M numbers separated with spaces - the elements of the matrix

Output
•Print the size of the lasrgest area of equal neighbour elements

Constraints
•3 <= N, M <= 1024
•Time limit: 0.1s
•Memory limit: 16MB

Hint: you can use the algorithm Depth-first search or Breadth-first search.
 
 */
class LargestAreaInMatrix
{
    private static bool[,] visited; 
    private static int[,] matrix; 
    private static int maxCountEqualNeighbours = 0; 
    private static int countEqualNeighbours = 0; 


    static void Main()
    {
        string[] inputNbrs = Console.ReadLine().Split();

        int n = int.Parse(inputNbrs[0]);
        int m = int.Parse(inputNbrs[1]);
        matrix = new int[n, m];

        //read matrix
        for (int i = 0; i < n; i++)
        {
            string[] rowElements = Console.ReadLine().Split();
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(rowElements[j]);
            }
        }

        //process matrix
        visited = new bool[n, m];

        // Find the largest area of equal neighbour elements
        for (short i = 0; i < n; i++)
        {
            for (short j = 0; j < m; j++)
            {
                CheckArea(i, j, matrix[i, j]);

                if (maxCountEqualNeighbours < countEqualNeighbours)
                {
                    maxCountEqualNeighbours = countEqualNeighbours;
                }

                countEqualNeighbours = 0;
            }
        }
       Console.WriteLine(maxCountEqualNeighbours);
    }

    private static void CheckArea(int row, int col, int currentElement)
    {
        //exit if out of the matrix or different element
        if ((row < 0) || (row >= matrix.GetLength(0)) || (col < 0) || (col >= matrix.GetLength(1))
            || currentElement != matrix[row, col])
        {
            return;
        }

        // exit if the cell is already cheched
        if (visited[row, col])
        {
            return;
        }

        // Mark the current cell as visited
        visited[row, col] = true;
        countEqualNeighbours++;

        //check all the position next to the current element  [row,col] - up, down, left and right
        CheckArea(row - 1, col, currentElement);
        CheckArea(row + 1, col, currentElement);
        CheckArea(row, col - 1, currentElement);
        CheckArea(row, col + 1, currentElement);    
    }
}
