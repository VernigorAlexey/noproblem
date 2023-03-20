// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество чисел: ");
int n = int.Parse(Console.ReadLine()!);
int result = 0;
Console.Write($"{firstNumber} {secondNumber} ");
for (int i = 3; i <= n; i++)
{
    result = firstNumber + secondNumber;
    Console.Write($"{result} ");
    firstNumber = secondNumber;
    secondNumber = result;
}
Console.WriteLine();
