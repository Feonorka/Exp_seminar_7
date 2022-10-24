//  Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.


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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

int[] MinMatrix(int[,] matrix)
{
    int min = matrix[0, 0];
    int minI = default;
    int minJ = default;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min) min = matrix[i, j];
            minI = i;
            minJ = j;
        }
    }
    Console.WriteLine($"Минимальный элемент: {min}");
    Console.WriteLine($"Координаты минимального элемента: {minI}, {minJ}");
    return new int[] { minI, minJ };
}

int[,] CreateNotMin(int[,] matrix, int[] arr)
{
    int[,] res = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int resI = default;
    int resJ = default;
    for (int i = 0; i < res.GetLength(0); i++)        // 0 - rows
    {
        if (i == arr[0]) resI++;
        for (int j = 0; j < res.GetLength(1); j++)    // 1- columns
        {
            if (resJ == arr[1]) resJ++;
            {
                res[i, j] = matrix[resI, resJ];
                resJ++;
            }
        }
        resI++;
        resJ = 0;
    }
    return res;
}

int[] MinIndex(int[,] matrix)
{
    int Min = matrix[0, 0];
    int[] resultIndex = { 0, 0 };
    int minValue = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minValue)
            {    
                minValue = matrix[i, j];
                resultIndex[0] = i;
                resultIndex[1] = j;
            }
        }

    }
    return resultIndex;
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 11);
PrintMatrix(array2D);
int[] arr = MinIndex(array2D);

int[,] Sarray2D = CreateNotMin(array2D, arr);
PrintMatrix(Sarray2D);
