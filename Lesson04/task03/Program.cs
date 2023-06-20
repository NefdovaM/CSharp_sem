/*Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.  
4 -> 24   
5 -> 120*/

int ReadInt()
{
    Console.Write("Введите целое число: ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int MultFrom1toA(int a)
{
    int mult = 1;
    for (int i = 1; i <= a; i++)
    {
        mult = mult * i;
    }
    return mult;
}

int number = ReadInt();
int multiplication = MultFrom1toA(number);
Console.WriteLine($"Произведение чисел от 1 до {number} - {multiplication}");