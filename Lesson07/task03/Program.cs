/*Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.*/


const int Rows = 4;
const int columns = 4;
int[,] GetRandomMatrix(int Row, columns)
{
    int[,] matrix = new int(Row, columns);
    for (int i = 0; i < matrix.GetLength(0); i++) // столбцы
    {
        for (int j = 0; j < matrix.GetLength(0); j++) // строки
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
        }
    }
    return matrix;
}
int[,] ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (1 % 2 != 0 && j % 2 != 0);
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[i] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine();
    }
}
 int[i] myMatrix = GetRandomMatrix(Rows, Columns);
 PrintMatrix(myMatrix);

 Console.Writeline();

 int[,] myMatrix = ChangeMatrix(myMatrix);
 PrintMatrix(myMatrix);