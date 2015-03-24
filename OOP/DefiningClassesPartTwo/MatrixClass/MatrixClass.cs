namespace MatrixClass
{
    using System;
    using System.Text;

    class MatrixClass<T>
    {
        public int Rows { get; set; }
        public int Cols { get; set; }
        private T[,] matrix;

        public MatrixClass(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[rows, cols];
        }

        public T this[int rows, int cols]
        {
            get 
            {
                if ((this.Rows < 0 || this.Rows > rows) ||
                    (this.Cols < 0 || this.Cols > cols))
                {
                    throw new IndexOutOfRangeException();
                }
                return this.matrix[rows, cols]; 
            }
            set
            {
                if ((this.Rows < 0 || this.Rows > rows) ||
                       (this.Cols < 0 || this.Cols > cols))
                {
                    throw new IndexOutOfRangeException();
                }
                this.matrix[rows, cols] = value;
            }
        }
        public static MatrixClass<T> operator +(MatrixClass<T> matrixOne, MatrixClass<T> matrixTwo)
        {
            if (matrixOne.Cols != matrixTwo.Cols ||
                matrixOne.Rows != matrixTwo.Rows)
            {
                throw new Exception("The matrices aren't the same size.");
            }
            for (int i = 0; i < matrixOne.Rows; i++)
            {
                for (int j = 0; j < matrixOne.Cols; j++)
                {
                    matrixOne[i, j] += (dynamic) matrixTwo[i, j];
                }
            }
            return matrixOne;
        }
        public static MatrixClass<T> operator -(MatrixClass<T> matrixOne, MatrixClass<T> matrixTwo)
        {
            if (matrixOne.Cols != matrixTwo.Cols ||
                matrixOne.Rows != matrixTwo.Rows)
            {
                throw new Exception("The matrices aren't the same size.");
            }
            for (int i = 0; i < matrixOne.Rows; i++)
            {
                for (int j = 0; j < matrixOne.Cols; j++)
                {
                    matrixOne[i, j] -= (dynamic)matrixTwo[i, j];
                }
            }
            return matrixOne;
        }
        public static MatrixClass<T> operator *(MatrixClass<T> matrixOne, MatrixClass<T> matrixTwo)
        {
            if (matrixOne.Cols != matrixTwo.Rows)
            {
                throw new Exception("The matrices cannot be multiplied.");
            }

            T temp;
            for (int matrixRow = 0; matrixRow < matrixOne.Rows; matrixRow++)
            {
                for (int matrixCol = 0; matrixCol < matrixOne.Cols; matrixCol++)
                {
                    temp = (dynamic) 0;
                    for (int index = 0; index < matrixOne.Cols; index++)
                    {
                        temp += (dynamic) matrixOne[matrixRow, index] * matrixTwo[index, matrixCol];
                    }
                    matrixOne[matrixRow, matrixCol] = (dynamic)temp;
                }
            }

            return matrixOne;
        }

        public static bool operator true(MatrixClass<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] != (dynamic) 0 )
                    {
                        return true;
                    } 
                }
            }
            return false;
        }
        public static bool operator false(MatrixClass<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder printer = new StringBuilder();

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    printer.Append(this.matrix[row, col] + "\t");
                }
                printer.AppendLine();
            }

            return printer.ToString();
        }
    }
}
