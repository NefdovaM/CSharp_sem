/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

Console.WriteLine("Enter your number: ");
string a = Console.ReadLine();
int number = Convert.ToInt32(a);

if (isEven(number))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}


bool isEven(int a)
{
    return a % 2 == 0;
}