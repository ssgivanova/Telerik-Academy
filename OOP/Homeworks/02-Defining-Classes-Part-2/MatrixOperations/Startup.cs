namespace MatrixOperations
{
    using System;

    class Startup
    {
        static void Main()
        {
            int n = 3;
            int m = 3;
            Matrix<int> matrix1 = new Matrix<int>(n, m);
            Matrix<int> matrix2 = new Matrix<int>(n, m);

            //generate matrix
            var generator = new Random();
            for (int i = 0; i < matrix1.SizeRows; i++)
            {
                for (int j = 0; j < matrix1.SizeCols; j++)
                {
                    matrix1[i, j] = (dynamic)generator.Next(-15, 100);
                }
            }

            for (int i = 0; i < matrix2.SizeRows; i++)
            {
                for (int j = 0; j < matrix2.SizeCols; j++)
                {
                    matrix2[i, j] = (dynamic)generator.Next(-15, 100);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix1[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Matrix<int> resultMatrix = matrix1 + matrix2;
            //Matrix<int> resultMatrix = matrix1 - matrix2;
            //Matrix<int> resultMatrix = matrix1 * matrix2;
            Console.WriteLine();
            for (int i = 0; i < resultMatrix.SizeRows; i++)
            {
                for (int j = 0; j < resultMatrix.SizeCols; j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            

        }
        
    }
}
