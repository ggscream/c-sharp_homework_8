/* Задача 54: Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

using static System.Console;

WriteLine("Введите размеры массива (кол-во строк и столбцов): ");
int m = Convert.ToInt32(ReadLine());
int n = Convert.ToInt32(ReadLine());

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
            Write($"{arr[i, j]}, ");
        }
        WriteLine();
    }
}

void RangeArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        { 
            for (int k = 0; k < arr.GetLength(1) - 1; k++) 
            { 
                if (arr[i, k] < arr[i, k + 1])
                {
                    double temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }

        }
    }
}

double[,] array = GetArray(m, n);
PrintArray(array);
WriteLine();
RangeArray(array);
PrintArray(array);

