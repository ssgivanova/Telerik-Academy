namespace MatrixOperations
{
    using System;
    using System.Collections.Generic;

    //Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
    public class Matrix<T> where T: struct, IComparable
    {
        private int sizeRows;
        private int sizeCols;
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.SizeRows = rows;
            this.SizeCols = cols;
            matrix = new T[rows, cols];
        }

        public int SizeRows
        {
            get { return this.sizeRows; }
            private set
            {
                if (value < 0 || value > int.MaxValue)
                {
                    throw new IndexOutOfRangeException("Index is outside the range");
                }
                else
                {
                    this.sizeRows = value;
                }
            }
        }

        public int SizeCols
        {
            get { return this.sizeCols; }
            private set
            {
                if (value < 0 || value > int.MaxValue)
                {
                    throw new IndexOutOfRangeException("Index is outside the range");
                }
                else
                {
                    this.sizeCols = value;
                }
            }
        }

        //Implement an indexer this[row, col] to access the inner matrix cells.
        // Indexer declaration
        public T this[int indexRow,int indexCol]
        {
            get
            {
                if (indexRow < 0 || indexRow > matrix.GetLength(0) 
                    || indexCol < 0 || indexCol > matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException(String.Format("Index is outside the matrix - ({0},{1})",indexRow,indexCol));
                }
                else
                {
                    T element = matrix[indexRow,indexCol];
                    return element;
                }
            }
            set
            {
                if (indexRow < 0 || indexRow > matrix.GetLength(0) 
                    || indexCol < 0 || indexCol > matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException(String.Format("Index is outside the matrix - ({0},{1})",indexRow,indexCol));
                }
                else
                {
                    matrix[indexRow, indexCol] = value;
                }
            }
        }


        //Matrix operations
        //Implement the operators + and - (addition and subtraction of matrices of the same size) and * 
        //for matrix multiplication.
        //Throw an exception when the operation cannot be performed.
        //Implement the true operator (check for non-zero elements).

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if(m1.SizeRows != m2.SizeRows || m1.SizeCols != m2.SizeCols)
            {
                throw new ArgumentException("Matrix are not of the same size - invalid operation!");
            }
            
            Matrix<T> resultMatrix = new Matrix<T>(m1.SizeRows,m1.SizeCols);
            for (int i = 0; i < resultMatrix.SizeRows; i++)
            {
                for (int j = 0; j < resultMatrix.SizeCols; j++)
                {
                    resultMatrix[i, j] = (dynamic)m1[i, j] + (dynamic)m2[i, j];
                }
            }
            return resultMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.SizeRows != m2.SizeRows || m1.SizeCols != m2.SizeCols)
            {
                throw new ArgumentException("Matrix are not of the same size - invalid operation!");
            }

            Matrix<T> resultMatrix = new Matrix<T>(m1.SizeRows, m1.SizeCols);
            for (int i = 0; i < resultMatrix.SizeRows; i++)
            {
                for (int j = 0; j < resultMatrix.SizeCols; j++)
                {
                    resultMatrix[i, j] = (dynamic)m1[i, j] - (dynamic) m2[i, j];
                }
            }
            return resultMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.SizeRows != m2.SizeCols)
            {
                throw new ArgumentException("Matrix are not of the same size - invalid operation!");
            }

            Matrix<T> resultMatrix = new Matrix<T>(m1.SizeRows, m1.SizeRows);
            for (int i = 0; i < resultMatrix.SizeRows; i++)
            {
                for (int j = 0; j < resultMatrix.SizeCols; j++)
                {
                    for (int k = 0; k < m1.SizeCols; k++) // or m2.SizeRows
                    {
                        resultMatrix[i, j] = resultMatrix[i, j] + (dynamic)m1[i, k] * (dynamic) m2[k, j];
                    }
                }
            }
            return resultMatrix;
        }

        public static bool operator true(Matrix<T> m)
        {
            for (int i = 0; i < m.SizeRows; i++)
            {
                for (int j = 0; j < m.SizeCols; j++)
                {
                    if ((dynamic) m[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> m)
        {
            for (int i = 0; i < m.SizeRows; i++)
            {
                for (int j = 0; j < m.SizeCols; j++)
                {
                    if ((dynamic)m[i, j] != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
