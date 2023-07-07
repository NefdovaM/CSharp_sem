/* Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр*/

int number = 145;

int digitsSum(int digit)
{
    if (digit <= 0) return 0;
    int res = digitsSum(digit / 10) + (digit % 10);
    return res;
}

Console.WriteLine(digitsSum(number));