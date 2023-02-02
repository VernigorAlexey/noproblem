
Console.Write("Введите первое число:");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите стерень числa:");
int y = Convert.ToInt32(Console.ReadLine());


double z = Math.Pow(x, y);

Console.Write($"Число {x} в степени {y} равно {z}:");