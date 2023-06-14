// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
int number = Random.Shared.Next(100, 1000);
Console.WriteLine(number);
int firstDigit = (number / 100) % 10;
//Console.WriteLine(firstDigit);
int lastDigit = number % 10;
//Console.WriteLine(lastDigit);
int midDigit = firstDigit*10 +lastDigit;
Console.WriteLine(midDigit);