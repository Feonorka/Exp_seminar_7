// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
int[] MatrixRowLowSumm(int[,] arr)
{
int[] arrLow = new int[arr.GetLength(0)];
int summ = default;

for (int i = 0; i < arr.GetLength(0); i++)
    {
        summ = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ += arr[i, j];
        }
        arrLow[i] = summ;
    }
PrintArray(arrLow);
return arrLow;
}
void MinRowIndex(int[] arrLow)
{
    int min = arrLow[0];
    int num = default;
    for (int k = 0; k < arrLow.Length; k++)
{
    if (min > arrLow[k]) num = k;
}
Console.WriteLine($"Строка с наименьшей суммой {num + 1}");
}

int[,] array2D = CreateMatrixRndInt(5, 6, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[] minArr = MatrixRowLowSumm(array2D);
MinRowIndex(minArr);