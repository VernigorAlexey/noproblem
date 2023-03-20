// Найти сумму элементов от M до N, N и M заданы
Console.WriteLine("Введите M:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N:");
int n = int.Parse(Console.ReadLine()!);
int sum = 0;
for (int i = m; i <= n; i++)
{
    sum += i;
}
Console.WriteLine($"Сумма элементов от {m} до {n} равна {sum}");
