/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да*/

Console.WriteLine("input value: ");
string n = Console.ReadLine();
int number = Convert.ToInt32(n);
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("yes");
}
else 
{
    Console.WriteLine("no");
}