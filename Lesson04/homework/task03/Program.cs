/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.*/

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Random.Shared.Next(0,9);
    Console.Write($"{array[i]} ");
}
