/*Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

int[] getRandomArray()
{
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }
    Console.WriteLine("Вводный массив: ");
    Console.WriteLine(string.Join(",", array));
    return array;
    
}

int [] array = getRandomArray();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        array[i] = -array[i];
    }
    else if(array[i] < 0)
    {
        array[i] = -array[i];
    }
}

Console.WriteLine("Измененный массив:");
Console.WriteLine(string.Join(",", array));
