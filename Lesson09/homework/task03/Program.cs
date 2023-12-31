﻿/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 9
m = 2, n = 3 -> A(m,n) = 29*/

Console.WriteLine("Введите первое натуральное число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int n = Convert.ToInt32(Console.ReadLine());

int AckermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return AckermanFunction(n - 1, 1);
    return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
}

Console.WriteLine(AckermanFunction(n, m));

//второй вариант
/* int ackOpt(int n, int m)
{
    while (n != 0)
    {
        if (m == 0) m = 1;
        else m = ackOpt(n, m - 1);
        n = n - 1;
    }
    return m + 1;
}

Console.WriteLine(ackOpt(n,m));*/