﻿/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/

Console.WriteLine("Введите любое пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
int x1 = x % 10;
int x2 = (x % 100 - x1) / 10;
int x3 = (x % 1000 - x2) / 100;
int x4 = (x % 10000 - x3) / 1000;
int x5 = (x % 100000 - x4) / 10000;
if(x1 == x5 && x2 == x4)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}