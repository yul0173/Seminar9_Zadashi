﻿// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Write("Введи M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи N: ");
int N = Convert.ToInt16(Console.ReadLine());
if (M>N)
for (int i = N; i <= M; i++)
Console.Write($" {i}");
else
    for (int i = M; i <= N; i++)
Console.Write($" {i}");
