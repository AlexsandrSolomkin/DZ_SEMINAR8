// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//==================================================================================================================================================================================

//Решение:

// Console.WriteLine("Ведите количество строк массива:");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Ведите количество столбцов массива:");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns);
// PrintArray(array);
// Console.WriteLine("===================================");
// PrintArray(SortRowsArray(array));

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

// int[,] SortRowsArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             for (int k = j + 1; k < array.GetLength(1); k++){
//                 if(array[i,j] < array[i,k]){
//                     int num1 = array[i,j];
//                     int num2 = array[i,k];
//                     array[i,j] = num2;
//                     array[i,k] = num1;
//                     k = j + 1;
//                 }
//             }
//         }
//     }
//     return array;
// }

//==================================================================================================================================================================================