﻿// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите первое целое число");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе целое число");
int number2 = int.Parse(Console.ReadLine()!);

if (number == number2 * number2) {
    Console.WriteLine("Да");
}
else {
    Console.WriteLine ("Нет");
}
