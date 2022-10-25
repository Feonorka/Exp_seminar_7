// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void BubbleSortUP(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] > inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
}

void BubbleSortDOWN(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j+1] > inArray[j])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
}

void SortMainMatrix(int[,] args)
{
    int colCount = args.GetLength(1);
    int rowCount = args.GetLength(0);
    int[,] arr = CreateMatrixRndInt(4, 4, 1, 10);

    Console.WriteLine("Исходный массив");
    PrintMatrix(arr);
    
    Console.WriteLine("Сортировка по строкам: ");
    int[] row = new int[colCount];

        for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                    row[j] = arr[i, j];
                    BubbleSortDOWN(row);
                    Insert(true, i, row, arr);
            }
    PrintMatrix(arr);

Console.WriteLine("Сортировка по столбцам: ");
    int[] col = new int[rowCount];
        for (int i = 0; i < colCount; i++)
            {
                for (int j = 0; j < rowCount; j++)
                    col[j] = arr[j, i];
                    BubbleSortDOWN(col);
                    Insert(false, i, col, arr);
    }
    PrintMatrix(arr);
}

void Insert(bool isRow, int dim, int[] source, int[,] dest)
{
    for (int k = 0; k < source.Length; k++)
    {
        if (isRow)
            dest[dim, k] = source[k];
        else
            dest[k, dim] = source[k];
     }
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
SortMainMatrix(array2D);
