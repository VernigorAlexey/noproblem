// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Write("Введите количество элементов массива: ");
int q = int.Parse(Console.ReadLine());
int[] array = new int[q];


{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
        Console.Write($"{array[i]} \t");
    }
}
Console.WriteLine();

int vork = 0;
for (int i = 0; i < array.Length / 2; i++)
{
    vork = array[i] * array[array.Length - 1 - i];

    Console.WriteLine($"Произведение пар чисел {i} - {array.Length - 1 - i} в одномерном массиве:{vork}");
}




