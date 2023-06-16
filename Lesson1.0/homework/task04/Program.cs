/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Enter your number from 1 to N: ");
string a = Console.ReadLine();
int n = Convert.ToInt32(a);
int iterable = 1;

while (iterable <= n)
{
    if (iterable % 2 == 0)
    {
        Console.WriteLine(iterable);
    }
    iterable++;
}