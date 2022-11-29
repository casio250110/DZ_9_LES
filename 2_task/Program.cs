// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. С помощью рекурсии!!!
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение натурального числа M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение натурального числа N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumMN(int m, int n)
{
    int result = m;
    if (m == n) return 0;
    else
    {
        m++;
        result = m + SumMN(m, n);
        return result;
    }
}

void SumMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

SumMToN(m,n);