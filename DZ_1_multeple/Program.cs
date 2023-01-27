// Выяснить, кратно ли число заданному, если нет, вывести остаток.


Console.WriteLine ("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = a % b;

if (c==0)

{
    Console.WriteLine ($"Первое число {a} кратно {b}");
}

else

{
    Console.WriteLine($"Первое число {a} не кратно {b}, остаток {c}!");
}