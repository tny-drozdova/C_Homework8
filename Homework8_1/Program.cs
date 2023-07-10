// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
//           1 4 7 2
//           5 9 2 3
//           8 4 2 4
// В итоге получается вот такой массив:
//           7 4 2 1
//           9 5 3 2
//           8 4 4 2


int InputNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] GenerateRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue);
        }
    }

    return array;
}

int[] SortRowDescending(int[] row) //The array of integer is taken as a parameter, the function will sort and reverse the numbers in the original array 
{
    Array.Sort(row);
    Array.Reverse(row);
    return row;
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int rowCount = InputNumber("Enter the number of rows: ");
int columnCount = InputNumber("Enter the number of columns: ");

int[,] originalArray = GenerateRandomArray(rowCount, columnCount, 0, 100);

Console.WriteLine("Original Array:");
PrintArray(originalArray);

int[,] modifiedArray = new int[rowCount, columnCount];

for (int i = 0; i < rowCount; i++)
{
    int[] row = new int[columnCount];

    for (int j = 0; j < columnCount; j++)
    {
        row[j] = originalArray[i, j];
    }

    int[] sortedRow = SortRowDescending(row);

    for (int j = 0; j < columnCount; j++)
    {
        modifiedArray[i, j] = sortedRow[j];
    }
}

Console.WriteLine("Modified Array:");
PrintArray(modifiedArray);
