// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите начальное значение M:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конечное значение N:");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Натуральные числа от M до N:");
for (int i = m; i <= n; i++)
{
    Console.Write(i + " ");
}
