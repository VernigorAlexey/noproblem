// Написать программу возведения числа А в целую стень B
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень B: ");
int b = int.Parse(Console.ReadLine()!);
int result = 1;
for (int i = 0; i < b; i++)
{
    result *= a;
}
Console.WriteLine($"Результат: {result}");
