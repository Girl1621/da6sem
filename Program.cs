// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь
// int[] array = new int[5];
// FillArray(array);
// int result = FindPositiveNumbers(array);
// Console.Write($"Количество чисел больше 0: {result} ");

// //заполняем массив
// void FillArray(int[] array)
// {
//     Console.WriteLine("введите 5 чисел: ");
//     for (var i = 0; i < array.Length; i++)
//     {
//         int numbers = Convert.ToInt32(Console.ReadLine());
//     }
// }

// //находим числа > 0
// int FindPositiveNumbers(int[] array)
// {
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

