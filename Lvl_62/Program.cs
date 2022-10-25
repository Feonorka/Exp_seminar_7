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
            for (int k = arr.GetLength(1) - 1; k >= 0; k--)
            {
                arr[arr.GetLength(1)-1, k] = i + j + k;
            }
        }
        
    }
return arr;
}
int[,] array = Ulitka(matrix);
PrintMatrix(array);

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
