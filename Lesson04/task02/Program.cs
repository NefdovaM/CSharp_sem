/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

int ReadInt()
{
    Console.Write("Введите целое число: ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int countOfNumbers(int num)
{
    int numCount = 0;
    while (num != 0)
    {
        numCount++;
        num = num / 10;
    }
return numCount;
}

/*static int countDigit(long n) 
{
        return (int) Math.Floor(Math.Log10(Math.Abs(n)) + 1);
}
*/
int num = ReadInt();
int totalDigits = countOfNumbers(num);
Console.WriteLine($"В числе {num} {totalDigits} чисел");
/*Console.WriteLine(countDigit(num));*/