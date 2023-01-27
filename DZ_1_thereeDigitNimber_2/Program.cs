// Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите целое трехзначное число, а мы покажем его вторую цифру");
int n = Convert.ToInt32(Console.ReadLine());
int m = Math.Abs (n);
int b = 99;
int c = 1000;
int a = m/10 % 10;

if (m > b && m < c)

{
          
            Console.WriteLine($"Вторая цифра числа {a}");
           
        }


else
{
    Console.Write("Введите трехзначное число!");
}
