// Выяснить является ли число чётным


Console.Write("Введите число чтобы выяснить, является ли оно четным:   ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine($"Число {a} является четным");
}

else
{
     Console.WriteLine($"Число {a} не является четным");
}
