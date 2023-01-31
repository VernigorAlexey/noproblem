// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("По двум заданным числам проверим является ли одно квадратом другого");
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());


if (a*a == b)

{
    Console.WriteLine($"Второе число {b} является квадратом первого числа {a} ");
}

else if (b*b == a)

{
    Console.WriteLine($"Первое число {a} является квадратом второго числа {b} ");
}

else

{
    Console.WriteLine("Числа не являются квадратами друг для друга");
}

