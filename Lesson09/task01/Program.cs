/*Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/

int number = 13;

void naturalNumber(int lastNumber)
{
    if (lastNumber <= 0) return;
    naturalNumber(lastNumber - 1);
    Console.Write($"{lastNumber} ");
}

naturalNumber(number);
Console.WriteLine();