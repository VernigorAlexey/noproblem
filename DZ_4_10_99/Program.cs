// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Console.Write("Введите первое число отрезка: ");
int a = int.Parse(Console.ReadLine());  // 10
Console.Write("Введите второе число отрезка: ");
int b = int.Parse(Console.ReadLine());  // 99
int count = 0;

for (int i = a; i <= b; i++)
{

    count++;

}
Console.WriteLine($"Количество элементов из отрезка [{a},{b}] равно {count}"); // 90
