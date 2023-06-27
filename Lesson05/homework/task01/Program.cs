/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Write("Введите число элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] getRandomArray()
{
    int[] array = new int[a];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(99, 1000);
    }
    return array;
}
int[] myArray = getRandomArray();
Console.WriteLine($"массив [{string.Join(", ", myArray)}]");

int GetEvenCount(int[] array)
{
    int evenCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenCount = evenCount + 1;
        }
    }
    return evenCount;
}

int evenCount = GetEvenCount(myArray);
Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");