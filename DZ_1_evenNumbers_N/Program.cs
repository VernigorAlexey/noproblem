// Показать четные числа от 1 до N


Console.WriteLine("Введите целое число (N). А мы покажем все чётные числа от 1 до N ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 2;

if (n >= m)
{
         while (m <= n)
        {
            Console.Write($" {m}");
            m = m + 2;
        }

    }


else
{
    Console.Write("Нет чисел. Введите другое число!");

}
