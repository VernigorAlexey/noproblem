// Найти кубы чисел от 1 до N


Console.WriteLine("Введите число N. Покажем кубы всех чисел от 1 до N включительно.");
int n = int.Parse(Console.ReadLine());
//double z = 0;  
//double y = 3;   второй вариант решения

Console.WriteLine("Кубы всех чисел от 1 до N.");

if (n > 0)
{
    for (int i = 1; i <= n; i++)

    {
        Console.WriteLine($"{i} \t {i * i * i}");
        //Console.WriteLine($"{i} \t {z = Math.Pow(i, y)}");    второй вариант решения
    }

}
else

{
    Console.WriteLine("Введите число больше ноля!");
}
