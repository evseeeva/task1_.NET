using System;

namespace task1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк матрицы:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов матрицы:");
            int M = Convert.ToInt32(Console.ReadLine());
            int[,] matrixA = new int[N, M];
            randomFillMatrix(matrixA);
            Console.WriteLine("Матрица A :");
            printMatrix(matrixA);
            int k = maxSumRow(matrixA);
            Console.WriteLine($"Строка с max суммой элементов : {k}");
            int[,] matrixB = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrixB[i, j] = matrixA[i, j] / matrixA[k, j];
                }
            }
            Console.WriteLine("Матрица B :");
            printMatrix(matrixB);
        }
        static int maxSumRow(int[,] matrix)
        {
            int k = 0;
            int N = matrix.GetUpperBound(0) + 1;
            int M = matrix.GetUpperBound(1) + 1;
            int sum;
            int maxSum = 0;
            for (int i = 0; i < N; i++)
            {
                sum = 0;
                for (int j = 0; j < M; j++)
                {
                    sum += matrix[i, j];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    k = i;
                }
            }
            return k;
        }
        static void randomFillMatrix(int[,] matrix)
        {
            int N = matrix.GetUpperBound(0) + 1;
            int M = matrix.GetUpperBound(1) + 1;
            Random rnd = new Random();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }
        }
        static void printMatrix(int[,] matrix)
        {
            int N = matrix.GetUpperBound(0) + 1;
            int M = matrix.GetUpperBound(1) + 1;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

       
    }
}

