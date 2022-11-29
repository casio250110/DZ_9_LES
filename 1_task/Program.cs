﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите значение натурального числа N: ");
int n = int.Parse(Console.ReadLine());
string FillNumbers(int n)
{
    if (n == 1) return n.ToString();
    else
    {
        return (n + " " + FillNumbers(n - 1));
    }

}
Console.WriteLine(FillNumbers(n)); 