// Найти сумму цифр числа
int number, sum = 0;
Console.Write("Введите целое число: ");
number = int.Parse(Console.ReadLine()!);

while (number != 0)
{
    sum += number % 10;
    number /= 10;
}

Console.WriteLine("Сумма цифр числа: {0}", sum);
