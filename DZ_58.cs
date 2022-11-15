// Задача 58: Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//==================================================================================================================================================================================

//Решение:

// Console.WriteLine("Введите размер матрицы, данное число отвечает за кол-во строк и столбцов: ");
// int rowsColumns = int.Parse(Console.ReadLine()!);

// int[,] matrixFirst = GetArray(rowsColumns);
// int[,] matrixSecond = GetArray(rowsColumns);

// PrintArray2Matrix(matrixFirst, matrixSecond);

// Console.WriteLine("Результирующая матрица будет:");

// PrintArray(MultiplyMatrix(matrixFirst, matrixSecond));

// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//     Console.WriteLine();
//     }
// }

// void PrintArray2Matrix(int[,] arrayFirst, int[,] arraySecond ){

//     for(int i = 0; i < arrayFirst.GetLength(0); i++){
//         for(int j = 0; j < arrayFirst.GetLength(1); j++){
//             Console.Write($"{arrayFirst[i,j]} ");
//         }

//         Console.Write("| ");

//         for(int j = 0; j < arraySecond.GetLength(1); j++){
//             Console.Write($"{arraySecond[i,j]} ");
//         }
    
//     Console.WriteLine();
//     }
// }

// int[,] GetArray(int rowsColumnsArray){
//     int[,] array = new int[rowsColumnsArray, rowsColumnsArray];
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             array[i,j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2){
//     int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     for (int i = 0; i < matrix1.GetLength(0); i++){
//         for (int j = 0; j < matrix2.GetLength(1); j++){
//             for (int k = 0; k < matrix2.GetLength(1); k++){
//                 resultMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
//             }
//         }
//     }
//     return resultMatrix;
// }

//==================================================================================================================================================================================