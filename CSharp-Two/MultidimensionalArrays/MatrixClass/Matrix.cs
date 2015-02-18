using System;
using System.Text;
using System.Linq;

namespace ClassMatrix
{
    class Matrix
    {
        private int rows;
        private int cols;
        private int[,] matrix;

        public Matrix(int rowCout, int colCount)
        {
            this.Rows = rowCout;
            this.Cols = colCount;
            this.matrix = new int[rowCout, colCount];
        }

        public void FillMatrix()
        {
            Console.WriteLine("Enter {0} lines with {1} numbers, separated by a comma:", this.Rows, this.Cols);

            for (int row = 0; row < this.Rows; row++)
            {
                Console.Write("Row {0, 3}: ", row);
                int[] numbers = Console.ReadLine()
                    .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

                if (numbers.Length != this.Cols)
                {
                    throw new ArgumentOutOfRangeException
                        ("number of columns", "The columns entered are not the same count as the columns of the matrix.");
                }

                for (int col = 0; col < this.Cols; col++)
                {
                    this.matrix[row, col] = numbers[col];
                }
            }
        }

        public int this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            private set
            {
                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set
            {
                this.cols = value;
            }
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.Rows, a.Cols);

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Cols; col++)
                {
                    result[row, col] = a[row, col] + b[row, col];
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.Rows, a.Cols);

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Cols; col++)
                {
                    result[row, col] = a[row, col] - b[row, col];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.Rows, b.Cols);
            int temp;

            for (int matrixRow = 0; matrixRow < result.Rows; matrixRow++)
            {
                for (int matrixCol = 0; matrixCol < result.Cols; matrixCol++)
                {
                    temp = 0;
                    for (int index = 0; index < result.Cols; index++)
                    {
                        temp += a[matrixRow, index] * b[index, matrixCol];
                    }
                    result[matrixRow, matrixCol] = temp;
                }
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    result.Append(this.matrix[row, col] + "\t");
                }
                result.AppendLine();
            }

            return result.ToString();
        }
    }
}