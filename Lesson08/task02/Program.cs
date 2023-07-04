/*Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.*/

const int rows = 4;
const int columns = 4;
int[,] GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

int[,] ChangeRowsAndColumns(int[,] array)
{
    int rowCount = array.GetLength(0);
    int columnCount = array.GetLength(1);
    int[,] ar = new int[columnCount, rowCount];
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < columnCount; j++)
        {
            ar[i, j] = array[j, i];
        }
    }
    return ar;
}

int[,] myMatrix = GetRandomMatrix(rows, columns);
PrintMatrix(myMatrix);
int[,] result = ChangeRowsAndColumns(myMatrix);
Console.WriteLine();
PrintMatrix(result);