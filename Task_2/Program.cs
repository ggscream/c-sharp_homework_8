/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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

double[] FindSum(double[,] arr)
{
    double[] sumArr = new double[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sumArr[i] = 0;

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumArr[i] += arr[i, j];
        }
    }

    return sumArr;
}

int FindTheRow (double[] arr)
{
    double minim = arr[0];
    int row = 0;

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minim)
        {
            minim = arr[i];
            row = i;
        }
    }

    return row;
}

WriteLine("Введите размеры массива (кол-во строк и столбцов): ");
int m = Convert.ToInt32(ReadLine());
int n = Convert.ToInt32(ReadLine());

if (m != n)
{
    WriteLine("Чтобы получить прямоугольный массив, количество столбцов должно быть равно количеству строк!");
}
else
{
    double[,] array = GetArray(m, n);
    PrintArray(array);
    WriteLine();
    double[] sumArray = FindSum(array);
    WriteLine($"Номер строки с наименьшей суммой элементов: {FindTheRow(sumArray)+1}");
}
