// Найти расстояние между точками в пространстве 2D/3D


double MetodSqrt(double x)

{

    double s = Math.Sqrt(x);
    return s;

}

double MetodPov(double x, double y)
{

    double z = Math.Pow(x, y);
    return z;

}

Console.WriteLine("Найдем расстояние между двумя точками в пространстве. Введите 2D если - двумерное или 3D если - трехмерное. ");
string username = Console.ReadLine();

if (username.ToLower() == "2d")
{

    Console.Write("Введите координату X1: ");
    double x1 = Convert.ToDouble(Console.ReadLine()); ;

    Console.Write("Введите координату Y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine()); ;

    Console.Write("Введите координату X2: ");
    double x2 = (float)Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координату Y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine()); ;

    double s = 2;   // 2 степень 
    double xx = (x2 - x1);
    double yy = (y2 - y1);


    double a = MetodPov(xx, s);

    double b = MetodPov(yy, s);


    double c = a + b;
    double d = MetodSqrt(c);

    Console.WriteLine($"Расстояние между двумя точками в двумерном пространстве 2D {d} едениц(-ы).");

}

else if (username.ToLower() == "3d")

{

    Console.Write("Введите координату X1: ");
    double x1 = Convert.ToDouble(Console.ReadLine()); ;

    Console.Write("Введите координату Y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine()); ;

    Console.Write("Введите координату Z1: ");
    double z1 = Convert.ToDouble(Console.ReadLine()); ;

    Console.Write("Введите координату X2: ");
    double x2 = (float)Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координату Y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine()); ;

    Console.Write("Введите координату Z2: ");
    double z2 = Convert.ToDouble(Console.ReadLine()); ;

    double xx = (x2 - x1);
    double yy = (y2 - y1);
    double zz = (z2 - z1);

    double a = MetodPov(xx, 2);    // второй способ (сразу 2 в аргумент)
    double b = MetodPov(yy, 2);
    double z = MetodPov(zz, 2);

    double c = a + b + z;
    double d = MetodSqrt(c);

    Console.WriteLine($"Расстояние между двумя точками в трехмерном пространстве 3D {d} едениц(-ы).");

}


else
{
    Console.WriteLine("Давай начнем с начала!");

}


