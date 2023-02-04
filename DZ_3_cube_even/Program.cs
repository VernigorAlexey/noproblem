// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите число N. Покажем кубы всех чисел от 1 до N включительно, заканчивающиеся на четную цифру");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Кубы всех чисел от 1 до N.");

if (n > 1)
{
    for (int i = 2; i <= n; i = i + 2)

    {
        Console.WriteLine($"{i} \t {i * i * i}");

    }

}

else if (n > 0)
{
    Console.WriteLine("Нет кубов заканчивающихся на четную цифру");
}


else

{
    Console.WriteLine("Введите число больше ноля!");
}
