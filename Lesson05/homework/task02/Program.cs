/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.Write("Введите число элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] getRandomArray()
{
    int[] array = new int[a];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-100, 100);
    }
    return array;
}
int[] myArray = getRandomArray();
Console.WriteLine($"массив [{string.Join(", ", myArray)}]");


int GetSumOfElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int result = GetSumOfElements(myArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {result}");