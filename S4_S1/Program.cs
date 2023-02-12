// Выяснить являются ли три числа сторонами треугольника


int ReadInt(){
    Console.WriteLine("Введите длину стороны треугольника: ");
    return int.Parse(Console.ReadLine()!);
}

bool Check(int a, int b, int c) => a<b+c && b<a+c && c<a+b;

int a = ReadInt();
int b = ReadInt();
int c = ReadInt();

Console.WriteLine(Check(a, b, c) ? "Три числа являются сторонами треугольника" : "Три числа не являются сторонами треугольника");


// // Написать программу преобразования десятичного числа в двоичное
// int ReadInt(){
//     Console.WriteLine("Enter decimal number: ");
//     return int.Parse(Console.ReadLine()!);
// }

// int decimalNum = ReadInt();
// int dicimalNum2 = decimalNum;
// int numLength = 0;
// int counter = 0;

// while(dicimalNum2 > 0){
//     numLength++;
//     dicimalNum2 /= 2;
// }

// int[] array = new int[numLength];
// Console.WriteLine(numLength);

// while (decimalNum > 0) {
//   array[counter] = decimalNum % 2;
//   decimalNum = decimalNum / 2;
//   counter++;
//   Console.WriteLine(decimalNum);
// }

// for (int i = array.Length - 1; i >= 0; i--)
// {
//     Console.Write(array[i]);
// }