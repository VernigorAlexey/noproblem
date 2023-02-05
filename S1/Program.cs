
Console.Write("Введите первое число:");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите стерень числa:");
int y = Convert.ToInt32(Console.ReadLine());

int z = 1;
// double z = Math.Pow(x, y);

for (int i=1; i<=y; i++)
{
    z = x*z;
    // z *=x;
}

Console.Write($"Число {x} в степени {y} равно {z}:");