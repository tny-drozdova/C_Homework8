// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// EXAMPLE:     2 4 | 3 4 2
//              3 2 | 3 3 1
// Результирующая матрица будет:
//              18 20 8
//              15 18 7


int[,] GenerateRandomMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue);
        }
    }

    return matrix;
}

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);

    if (columns1 != rows2)
    {
        throw new ArgumentException("Two matrix cannot be multiplied.");
    }

    int[,] result = new int[rows1, columns2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            int sum = 0;

            for (int k = 0; k < columns1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }

            result[i, j] = sum;
        }
    }

    return result;
}

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int rows1 = 2;
int columns1 = 3;
int rows2 = 3;
int columns2 = 2;

int[,] matrix1 = GenerateRandomMatrix(rows1, columns1, 0, 10);
int[,] matrix2 = GenerateRandomMatrix(rows2, columns2, 0, 10);

Console.WriteLine("Matrix 1:");
PrintMatrix(matrix1);

Console.WriteLine("Matrix 2:");
PrintMatrix(matrix2);

int[,] result = MultiplyMatrices(matrix1, matrix2);

Console.WriteLine("Multiplication Result:");
PrintMatrix(result);



