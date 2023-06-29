/*Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве .
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

// int[] RandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Random.Shared.Next(1, 10);
//     }
//     return array;
// }


// int[] arr = RandomArray(7);
// Console.WriteLine($"Массив [{string.Join(", ", arr)} ]");

// int[] NewArray = new int[(arr.Length + 1) / 2];

// for (int i = 0; i < NewArray.Length; i++)
// {
//     NewArray[i] = arr[i] * arr[arr.Length - 1 - i];
// }

// if (arr.Length % 2 != 0)
// {
//     NewArray[NewArray.Length -1] = arr[arr.Length / 2];
// }

// Console.WriteLine($"Пары [{string.Join(", ", NewArray)} ]");

int i = 10;
i += 2;
//i = i+2;
Console.WriteLine("i += 2 =" + i);
i *= 5;
//i = i * 5
Console.WriteLine("i *= 2 =" + i);
i /= 6;
// i = i / 6
Console.WriteLine("i /= 2 =" + i);
i -= 7;
//i = i - 7
Console.WriteLine("i -= 2 =" + i);


i++;
//i = i + 1
Console.WriteLine("i++ =" + i);

i--;
//i = i - 1
Console.WriteLine("i-- =" + i);