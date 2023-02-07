// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Console.Write("Задайте число трехзначных элементов массива: ");
int t = int.Parse(Console.ReadLine());
int[] array = new int[t];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]}  | \t");

}

int m = 0;
int n = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        m++;
    }

    else
    {
        n++;
    }

}
Console.WriteLine();
Console.WriteLine($" Четных чисел в массиве: {m} , нечетных чисел в массиве {n}");