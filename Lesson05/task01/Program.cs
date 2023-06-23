/*Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.*/

int[] getRandomArray()
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }
    return array;
}

int sumOfPositiveElements(int[] massive)
{
    int sumPositiveElements = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] > 0)
        {
            sumPositiveElements += massive[i];
        }
    }
    return sumPositiveElements;
}
int sumOfNegativeElements(int[] massive)
{
    int sumNegativeElements = 0;
    for(int i = 0; i < massive.Length; i++)
    {
        if (massive[i] < 0)
        {
            sumNegativeElements += massive[i];
        }
    }
    return sumNegativeElements;

}

int [] myArray = getRandomArray();
int sumPositive = sumOfPositiveElements(myArray);
int sumNegative = sumOfNegativeElements(myArray);

Console.WriteLine($"[{string.Join(", ", myArray)} ]");
Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");