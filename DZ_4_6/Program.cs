// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.Write("Введите количество элементов массива: ");
int q = int.Parse(Console.ReadLine()!);

double[] array = new double [q];
 Random rand = new();
// double min = 10.0;
//  double max = 0.0;
// {
  for (int i = 0; i < array.Length; i++)
  {
      array[i]  = rand.Next(0, 10) + rand.NextDouble();
 ;
     Console.WriteLine($"{array[i]} \t");

  }

//     }
// }
// Console.WriteLine();

// int vork = 0;
// for (int i = 0; i < array.Length / 2; i++)
// {
//     vork = array[i] * array[array.Length - 1 - i];

//     Console.WriteLine($"Произведение пар чисел {i} - {array.Length - 1 - i} в одномерном массиве:{vork}");
// }





// // Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

// int ReadInt(string text)
//     {
//         Console.WriteLine(text);
//         return int.Parse(Console.ReadLine()!);
//     }

// void FillArray (int [,] array)
//     {
//         Random rnd = new Random();
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//                 array[i,j] = rnd.Next(0,10);
//         }
//     }

// void PrintArray(int [,] array, string text)
//     {
//         Console.WriteLine("\n");
//         Console.WriteLine(text);
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//                 if (array[i,j] >= 0)
//                     Console.Write($" {array[i,j]} \t");
//                 else
//                     Console.Write($"{array[i,j]} \t");
//         Console.WriteLine();
//         }
//     }



// int MeanRows(int [,] array)
// { 
//     int count = 0;
//     int sumTotal = 0;
//     int sumRow = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//                 sumRow += array[i,j];
//         sumTotal += sumRow;
//         sumRow = 0;
//         count++;
//         }
//     return sumTotal/count;
// }
// int [,] numbers = new int[3,3];

// FillArray(numbers);
// PrintArray(numbers, "Оригинальный массив: ");
// Console.WriteLine(MeanRows(numbers));