// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//      Например, задан массив:
//                      1 4 7 2
//                      5 9 2 3
//                      8 4 2 4
//                      5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] GenerateRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }

    return matrix;
}

int FindRowWithSmallestSum(int[,] matrix)
{
    int smallestSum = int.MaxValue;
    int smallestSumRowIndex = -1;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }

        if (rowSum < smallestSum)
        {
            smallestSum = rowSum;
            smallestSumRowIndex = i;
        }
    }

    return smallestSumRowIndex;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }

        Console.WriteLine();
    }
}

int rows = 5;
int columns = 4;
int min = 0;
int max = 10;

int[,] matrix = GenerateRandomMatrix(rows, columns, min, max);
PrintMatrix(matrix);
int rowWithSmallestSum = FindRowWithSmallestSum(matrix);
Console.WriteLine($"Row with the smallest sum: {rowWithSmallestSum}");
