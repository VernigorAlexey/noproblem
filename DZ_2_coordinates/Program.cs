// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Задайте номер четверти (от 1 до 4) Декартовой системы координат, покажем диапазоны для возможных координат");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter == 1)
{
    Console.WriteLine($"Для четверти {quarter} возможны координаты: X>0,Y>0");

}

else if (quarter == 2)
{
    Console.WriteLine($"Для четверти {quarter} возможны координаты: X<0,Y>0");

}

else if (quarter == 3)
{
    Console.WriteLine($"Для четверти {quarter} возможны координаты: X<0,Y<0");

}

else if (quarter == 4)
{
    Console.WriteLine($"Для четверти {quarter} возможны координаты: X>0,Y<0");

}

else
{
    Console.WriteLine("Неправильно задана четверть!");

}