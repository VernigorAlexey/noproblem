// Найти третью цифру числа или сообщить, что её нет


Console.WriteLine("Возьмем случайное число и определим его третью цифру, или поймем что её нет! ");
int n = new Random().Next(0, 1000000);
//int n = Convert.ToInt32(Console.ReadLine());  для ручной проверкм
Console.WriteLine($"Случайное число : {n} ");


if (n > 99)

{
    while (n > 999)  n = n / 10;
    n = n % 10; 
   

    Console.WriteLine($"Третья цифра : {n} ");


}

else

{
    Console.WriteLine("Третьей цифры нет");
}