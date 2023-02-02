// Найти расстояние между точками в пространстве 2D/3D



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

    double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

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

    double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));

    Console.WriteLine($"Расстояние между двумя точками в трехмерном пространстве 3D {d} едениц(-ы).");

}


else
{
    Console.WriteLine("Давай начнем c начала!");

}