// // Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.WriteLine ("Введите k и b двух прямых, найдем точку пересечения.");
void CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = 0;
    double y = 0;
    {

        if ((k1 == k2 && b1 == b2))

        {
            Console.Write("Заданные прямые совпадают!");


        }
        else if (k1 == k2)
        {
            Console.Write("Заданные прямые паралельны!");
        }

        else
        {
            x = (b1 - b2) / (k2 - k1);
            y = (k2 * b1 - k1 * b2) / (k2 - k1);

            Console.Write($"Точка пересечения заданных прямых: ({x} ; {y})");
        }
    }
}

Console.WriteLine("Введите b1: ");
double bb = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1: ");
double kk = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2: ");
double bbb = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2: ");
double kkk = double.Parse(Console.ReadLine()!);

CrossPoint(kk, bb, kkk, bbb);