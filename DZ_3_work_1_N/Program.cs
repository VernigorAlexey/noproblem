﻿// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число N. Компьютер вычислит произведения всех чисел от 1 до N включительно.");
int n = int.Parse(Console.ReadLine());
long m = 1;
int i = 1;

if (n > 0)
{
    while (i <= n)

    {
        m = m * i;
        // m *= i;  или так возможно написать
        i++;

    }
    Console.WriteLine($"Произведение чисел от 1 до {n} равно {m}");
}
else

{
    Console.WriteLine("Введите число больше ноля!");
}

