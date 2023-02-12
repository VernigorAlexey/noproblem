// Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.Write("Введите количество элементов массива: ");
int q = int.Parse(Console.ReadLine());
int[] array = new int[q];


{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write($"{array[i]} \t");
    }
}

int sum = 0;
for (int i = 1; i < array.Length; i += 2)
{
    sum += array[i];
}


Console.WriteLine();
Console.WriteLine($"Cуммa чисел одномерного массива стоящих на нечетной позиции равна:{sum}");
