// Написать программу вычисления функции Аккермана


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    else
    {
        return 0;
    }
}

    Console.WriteLine("Введите значения m и n для функции Аккермана:");
    Console.Write("m = ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");



