/*Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> нет
*/

int[] getRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }
    Console.WriteLine("Вводный массив: ");
    Console.WriteLine(string.Join(",", array));
    return array;
}

bool isArrayContains(int[] iArr, int value)
{

    for (int i = 0; i < iArr.Length; i++)
    {
        if (value == iArr[i])
        {
            return true;
        }
    }

    return false;
}

int[] array = getRandomArray(878);
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (isArrayContains(array, number))
{

    Console.WriteLine("Число присутствует в массиве. ");
}
else
{
    Console.WriteLine("Число не присутствует в массиве. ");
}

