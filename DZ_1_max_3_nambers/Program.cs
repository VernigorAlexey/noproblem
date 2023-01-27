// Найти максимальное из трех чисел


Console.WriteLine ("Введите три числа и мы определим максимальное из них");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if     (b>max) max = b;
else if (c>max) max = c;

Console.Write ($"Максимальное число {max} ");

