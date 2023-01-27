// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите два числа для проверки, является ли первое квадратом второго");
Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b*b)
{
        Console.WriteLine ($"Первое число {a} является квадратом второго числа {b}");
                   }

else
{
    Console.WriteLine ($"Первое число {a}  НЕ является квадратом второго числа {b} ");
}
