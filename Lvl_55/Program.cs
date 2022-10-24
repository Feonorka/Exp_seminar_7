// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

int[,] TreanspMatrix(int[,] matrix)
{
    int[,] res = new int[matrix.GetLength(1), matrix.GetLength(0)];
    

    for (int i = 0; i < matrix.GetLength(0); i++)        // 0 - rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)    // 1- columns
        {
            res[j, i] = matrix[i, j];
        }
    }

    return res;
}

int[,] array2D = CreateMatrixRndInt(4, 4, -100, 100);
PrintMatrix(array2D);
Console.WriteLine();
if (array2D.GetLength(1) == array2D.GetLength(0))
{
    int[,]result = TreanspMatrix(array2D);
    PrintMatrix(result);
}
else Console.Write("Ваша матрица не квадратная");

void TransponArray2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            int num = matrix[j, i];
            matrix[j, i] = matrix[i, j];
            matrix[i, j] = num;
        }
    }
}
TransponArray2(array2D);