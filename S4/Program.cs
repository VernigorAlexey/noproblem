
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



void PrintArray(int[] array)
{
    foreach(int element in array)
        Console.Write($"{element} ");
    Console.WriteLine();
}
int[] CreateArray(int length, int lowest, int hightest)
{
    Random random = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(lowest, hightest + 1);
    return array;
}
bool Constains(int[] array, int value)
{
    foreach(int element in array)
        if (element == value)
            return true;
    return false;
}
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int length = ReadInt("Enter size of array: ");
int lowest = ReadInt("Enter left part of array range: ");
int hightest = ReadInt("Enter right part of array range: ");
int[] array = CreateArray(length, lowest, hightest);
PrintArray(array);
int value = ReadInt("Enter element to find: ");
Console.WriteLine(Constains(array, value) ? "There is element into array" : "There is no element into array" );