/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

start:
Console.WriteLine("Введите любое число от 1 до 100000: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (99 < x && x < 999)
{
    int x1 = x % 10;
    Console.WriteLine($"{x1} - третья цифра числа");
}

else if (999 < x && x < 10000)
{
    int x1 = x % 10;
    int x2 = (x % 100 - x1) / 10;
    Console.WriteLine($"{x2} - третья цифра числа");
}

else if (9999 < x && x < 100000)
{
    int x1 = x % 10;
    int x2 = (x % 100 - x1) / 10;
    int x3 = (x % 1000 - x2) / 100;
    Console.WriteLine($"{x3} - третья цифра числа");
}
else if (x > 100000)
{

    Console.Write("Слишком длинное число. Попробуйте снова. ");
    goto start;
}
