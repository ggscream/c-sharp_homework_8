/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

using static System.Console;

double[,] GetArray(int rows, int cols)
{
    double[,] arr = new double[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            arr[i, j] = new Random().Next(-10, 10);
        }
    }

    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"\t{arr[i, j]}, ");
        }
        WriteLine();
    }
}

double[,] MatrixMultiplication(double[,] arr1, double[,] arr2)
{
    double[,] finalMatrix = new double[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            double sum = 0;

            for (int p = 0; p < arr1.GetLength(1); p++)
            {
                sum += arr1[i, p] * arr2[p, j];
            }

            finalMatrix[i, j] = sum;
        }
    }
    
    return finalMatrix;
}

WriteLine("Введите размеры первой матрицы (кол-во строк и столбцов): ");
int m = Convert.ToInt32(ReadLine());
int n = Convert.ToInt32(ReadLine());
WriteLine("Введите размеры второй матрицы (кол-во строк и столбцов): ");
int l = Convert.ToInt32(ReadLine());
int k = Convert.ToInt32(ReadLine());

if (n != l)
{
    WriteLine("Матрицы должны быть согласованы: число столбцов в первой матрице должно быть равно числу строк во второй!");
}
else
{
    double[,] matrix1 = GetArray(m, n);
    double[,] matrix2 = GetArray(l, k);
    PrintArray(matrix1);
    WriteLine();
    PrintArray(matrix2);
    WriteLine();
    double[,] matrix3 = MatrixMultiplication(matrix1, matrix2);
    PrintArray(matrix3);
}