// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.Write("Введите количество строк: ");
// int raws = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] array = GetArray(raws, columns, 0, 99);
// PrintArray(array);

// double[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     double[,] res = new double[m,n];

//     for (int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++){
//             res[i, j] = new Random(). Next(minValue, maxValue + 1) / 10.0;
//         }

//     }
//     return res;
// }

// void PrintArray(double[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//        for(int j = 0; j < array.GetLength(1); j++){
//         Console.Write($"{array[i,j]} ");
//        } 
//        Console.WriteLine();
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает два числа(строка, столбец), проверяя есть ли такая позиция в двумерном массиве 
//и возвращает сообщение о том, что оно найдено, а также какое число стоит на этом месте или же указание, что такого элемента нет.


// Console.Write("Введите индекс строки: ");
// int raws = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите индекс стобца: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] numbers = new int [3, 4];
// FArray(numbers);
// PArray(numbers);

// if (raws < numbers.GetLength(0) && columns < numbers.GetLength(1)) Console.WriteLine(numbers[raws, columns]);
// else Console.WriteLine($"{raws}{columns} такого числа в массиве нет");


// void FArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//        for(int j = 0; j < array.GetLength(1); j++){ 
//         array[i,j]= new Random().Next(1,10);
//         }
//        } 
//     }

// void PArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j <array.GetLength(1); j++){
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Random random = new Random();
// int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = random.Next(1, 10);
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Average is... ");
// for (int j = 0; j < arr.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         sum += arr[i, j];
//     }
//     Console.Write($"{ sum / arr.GetLength(0)} ");
// }
// Console.ReadLine();