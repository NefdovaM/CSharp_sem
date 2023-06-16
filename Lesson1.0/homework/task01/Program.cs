/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Enter the first number: ");
string a = Console.ReadLine();
int numberA = Convert.ToInt32(a);
Console.WriteLine("Enter the second number: ");
string b = Console.ReadLine();
int numberB = Convert.ToInt32(b);
if (numberA == numberB)
{
    Console.WriteLine("numbers are seam");
    return;
}
if (numberA > numberB)
{
    Console.WriteLine(numberA + "(max) " + numberB + "(min)");
}
else
{
    Console.WriteLine(numberB + "(max) " + numberA + "(min)");
}