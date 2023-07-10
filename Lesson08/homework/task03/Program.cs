/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
6 16
9 6*/

const int rows = 2;
const int columns = 2;
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
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] powMatrix(int[,] matrix1, int[,] matrix2)
{

    if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
    {
        throw new System.InvalidOperationException("Размеры массивов отличаются");
    }

    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return result;
}

int[,] myMatrix1 = GetRandomMatrix(rows, columns);
PrintMatrix(myMatrix1);
Console.WriteLine("_________");
Console.WriteLine();
int[,] myMatrix2 = GetRandomMatrix(rows, columns);
PrintMatrix(myMatrix2);
Console.WriteLine("_________");
Console.WriteLine();
int[,] result = powMatrix(myMatrix1, myMatrix2);
PrintMatrix(result);