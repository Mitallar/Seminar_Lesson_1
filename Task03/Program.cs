﻿// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите натуральное число ");
int N = Convert.ToInt32(Console.ReadLine());

// for(int i = -N; i <= N; i++)
// {
//     Console.Write($"{i} ");
// }

 int count = -N;
    while (count <= N)
    {
        Console.Write($"{count} ");
        count++;
    }