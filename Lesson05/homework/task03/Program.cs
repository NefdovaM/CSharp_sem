/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());

double[] GetArray()
{
    double[] array = new double[a];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(Random.Shared.NextDouble() * 10, 2);
    }
    return array;
}
double GetMaxMin(double[] array)
{
    double max = 0.0;
    double min = 10.0;
    double sum = 0.0;
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        max = array[i];
        if (min > array[i])
        min = array[i];
    }
    sum = max - min;
    return sum;
}

double[] array = GetArray();
double sum = GetMaxMin(array);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Разница между максимальным и минимальным числами равна: {sum}");
