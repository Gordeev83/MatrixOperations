namespace MatrixOperations
{
    class MatrixOperations
    {
        static void Main()
        {
            int n = 2; 

            int[,] matrix1 = { { 1, 2 },
                           { 3, 4 } };

            int[,] matrix2 = { { 5, 6 },
                           { 7, 8 } };

            int num = 2;
            int[,] result1 = MultiplyMatrixByNumber(matrix1, num);

            Console.WriteLine("Результат умножения первой матрицы на число {0}:", num);
            PrintMatrix(result1);

            int[,] result2 = AddMatrices(matrix1, matrix2);

            Console.WriteLine("Результат сложения двух матриц:");
            PrintMatrix(result2);

            int[,] result3 = MultiplyMatrices(matrix1, matrix2);

            Console.WriteLine("Результат произведения двух матриц:");
            PrintMatrix(result3);
        }

        static int[,] MultiplyMatrixByNumber(int[,] matrix, int num)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] * num;
                }
            }

            return result;
        }

        static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (cols1 != rows2)
            {
                throw new Exception("Матрицы нельзя перемножить");
            }

            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
