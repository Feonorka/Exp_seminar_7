//Задача 58: Задайте две матрицы. Напишите программу, которая будет
//находить произведение двух матриц.

Console.WriteLine("Введите колличество столбцов (Первой) матрицы и строк (Второй) матрицы");
int columnRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество строк (Первой) матрицы");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов (Второй) матрицы");
int columns = Convert.ToInt32(Console.ReadLine());

// Метод создания двумерного массива
int [,] GetArray(int rows, int columns)
{
    int [,] array = new int [rows, columns];
    Random randomValue = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomValue.Next(0, 10);
        }
    }
    return array;
}

/// Метод печати массива
void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6}", array[i, j]);
        }
    Console.WriteLine();
    }
}

/// Метод нахождения произведения двух матриц
int [,] ArrayMultiply(int [,] arrayFirst, int [,] arraySecond)
{
    int arraySum = 0;
    int [,] arrayThird = new int [arrayFirst.GetLength(0), arraySecond.GetLength(1)];
    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arraySecond.GetLength(1); j++)
        {
            for (int k = 0; k < arrayFirst.GetLength(1); k++)
            {
                arraySum = arraySum + (arrayFirst[i,k] * arraySecond[k,j]);
            }
        arrayThird[i, j] = arraySum;
        arraySum = 0;
        }
    }
    return arrayThird;
}

int [,] firstArray = GetArray(rows, columnRows);
int [,] secondArray = GetArray(columnRows, columns);

Console.WriteLine($"(Первая) матрица. Строк = ({rows}), столбцов = ({columnRows}):");
PrintArray(firstArray);
Console.WriteLine();
Console.WriteLine($"(Вторая) матрица. Строк = ({columnRows}), столбцов = ({columns}):");
PrintArray(secondArray);
int [,] thirdArray = ArrayMultiply(firstArray, secondArray);
Console.WriteLine();
Console.WriteLine($"Произведение матриц. Строк = ({rows}), столбцов = ({columns}):");
PrintArray(thirdArray);