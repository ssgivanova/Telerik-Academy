using System;

//Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20) and prints a 
//matrix holding the numbers from 1 to N*N in the form of square spiral like in the examples below.

//Input
//•The input will always consist of a single line containing a single number - N.

//Constraints
//•N will always be a valid integer number.
//•1 ≤ N ≤ 20

//2 
//1 2
//4 3 
//3 
//1 2 3
//8 9 4
//7 6 5 
//4
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7 


class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] spiralMatrix = new int[n, n];
        int row = 0;
        int col = 0;
        int maxRotations = n * n;
        string direction = "right";

        for (int i = 1; i <= maxRotations; i++)
        {
            if (direction == "right" && (col > n - 1 || spiralMatrix[row, col] != 0))
            {
                direction = "down";
                row++;
                col--;
            }

            if (direction == "down" && (row > (n - 1) || spiralMatrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }

            if (direction == "left" && (col < 0 || spiralMatrix[row, col] != 0))
            {
                direction = "up";
                row--;
                col++;
            }

            if (direction == "up" && (row < 0 || spiralMatrix[row, col] != 0))
            {
                direction = "right";
                row++;
                col++;
            }

            spiralMatrix[row, col] = i;

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

        //print matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ", spiralMatrix[i, j]);
            }
            Console.WriteLine();
        }

    }
}
