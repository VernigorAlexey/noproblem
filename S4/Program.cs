
//  Задать массив из 12 элементов заполненных числами [0,9] найти сумму положительных / отрицательных элементов массива.

int[] array = new int [12];
int i = 0;
int result1 = 0;
int result2 = 0;

while (i < array.Length)
{
    Console.Write($"Введите {i+1} элемент массива: ");
    array[i] = int.Parse(Console.ReadLine() ?? "0");
    i++;
}
i = 0;

while (i < array.Length)
{
    if (array[i] >= 0)
    {
        result1 = result1 + array[i];
    }
    else
    {
        result2 = result2 + array[i];
    }
    i++;
}

Console.WriteLine($"Сумма положительных элементов массива равна {result1}");
Console.WriteLine($"Сумма отрицательных элементов массива равна {result2}");