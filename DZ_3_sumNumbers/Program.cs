// Подсчитать сумму цифр в числе

Console.WriteLine("Введите число. Робот сосчитает сумму его чисел =)");
int n = int.Parse(Console.ReadLine());
int c = n; // для печати ответа
n = Math.Abs(n);

int m = 0;

while (n > 0)
{
    m = m + n % 10;
    n = n / 10;
}

Console.WriteLine($"Сумма цифр числа {c} равна {m}");


