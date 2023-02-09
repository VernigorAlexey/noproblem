// Выяснить являются ли три числа сторонами треугольника

// int Metod (int a, int b, int c)

// {
//     bool i = false;

//   { if (a<b+c || b<a+b || c < a+b)
//    { 
//      bool i = true;
//    }
//   }
//   return i;

// }

// Console.WriteLine("три числа являются сторонами треугольника");


// Console.WriteLine("Hello, World!");


int ReadInt(){
    Console.WriteLine("Введите длину стороны треугольника: ");
    return int.Parse(Console.ReadLine()!);
}

bool Check(int a, int b, int c) => a<b+c && b<a+c && c<a+b;

int a = ReadInt();
int b = ReadInt();
int c = ReadInt();

Console.WriteLine(Check(a, b, c) ? "Три числа являются сторонами треугольника" : "Три числа не являются сторонами треугольника");