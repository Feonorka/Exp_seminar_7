// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrix = new int[4,4];

int [,] Ulitka(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[0, i] = i + 1;
        for (int j = 0; j <= arr.GetLength(1); j++)
        {
            arr[i, arr.GetLength(1) - 1] = i + j;
            for (int k = arr.GetLength(1) - 1; k > 0; k--)
            {
                arr[arr.GetLength(1) - 1, k] = arr.GetLength(1) + k;
            }
        }
        
    }
return arr;
}
int[,] array = Ulitka(matrix);
PrintMatrix(array);

// Способ вернуть сразу два значения в одном методе
// int[] Method()
// {
//     int f = 3;
//     int d = 3;
//     return new int[] { f, d };
// }
// System.Console.WriteLine(Method()[0]);
// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
// Создание одномерного массива 
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
// Печать массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.WriteLine($"{arr[i]}");
    }
    Console.WriteLine("]");
}
// Заполняет массив по строкам
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)        // 0 - rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)    // 1- columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} | ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("|");
    }
}
int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
//PrintMatrix(array2D);
// Заполняет массив по столбцам
int[,] MakeMatrixColumnsRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int j = 0; j < matrix.GetLength(0); j++)        // 0 - rows
    {
        for (int i = 0; i < matrix.GetLength(1); i++)    // 1- columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}