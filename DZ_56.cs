// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//==================================================================================================================================================================================

//Решение:

// Console.WriteLine("Ведите количество строк массива:");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Ведите количество столбцов массива:");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns);
// PrintArray(array);
// Console.WriteLine($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {MinSumElementsRows(array)} строка");

// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//     Console.WriteLine();
//     }
// }

// int[,] GetArray(int rowsArray, int columnsArray){
//     int[,] array = new int[rowsArray, columnsArray];
//     for (int i = 0; i < rowsArray; i++){
//         for (int j = 0; j < columnsArray; j++){
//             array[i,j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// int MinSumElementsRows(int[,] array){
//     int minRowsArray = 0;
//     int minRowsSum = 0;
//     int min = 0;
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             min += array[i,j];
//         }

//         if (minRowsSum == 0){
//             minRowsSum = min;
//             minRowsArray = i + 1;
//             min = 0;
//         } else if(minRowsSum > min){
//             minRowsSum = min;
//             minRowsArray = i + 1;
//             min = 0;
//         }
//     }
//     return minRowsArray;
// }

//==================================================================================================================================================================================