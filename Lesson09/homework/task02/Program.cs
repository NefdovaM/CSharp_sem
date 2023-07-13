/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
Console.WriteLine("Введите первое натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int m = Convert.ToInt32(Console.ReadLine());

int sumOfNumbers(int n, int m)
{
    if (m == n) return m;
    return n + sumOfNumbers(n + 1, m);
}

Console.WriteLine($"Сумма чисел равна: {sumOfNumbers(n, m)}");