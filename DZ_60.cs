// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//==================================================================================================================================================================================

//Решение:

// Console.WriteLine("Ведите количество строк массива:");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Ведите количество столбцов массива:");
// int columns = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Ведите размер глубины массива:");
// int depthArray = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Для задания диапазона чисел, введите минимальное значение:");
// int minElement = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Для задания диапазона чисел, введите максимальное значение:");
// int maxElement = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Массив размером {rows} x {columns} x {depthArray}");

// CheckingLaunch_GetArray_PrintArray(rows, columns, depthArray, minElement, maxElement);

// void CheckingLaunch_GetArray_PrintArray(int rank1, int rank2, int rank3, int min, int max){
//     int sizeArray = rank1 * rank2 * rank3;
//     int countOriginalNumber = max - min + 1;

//     if (sizeArray > countOriginalNumber){
//         Console.WriteLine("Нельзя создать массив с оригинальными элементами.");
//         Console.WriteLine($"Свободных мест в массиве: {sizeArray}");
//         Console.WriteLine($"Кол-во заданных оригинальных значений: {countOriginalNumber}");
//     } else {
//         int[,,] array = GetArray(rank1, rank2, rank3, min, max);
//         PrintArray(array);
//     }
// }

// void PrintArray(int[,,] array){
//     int elementsRowsColumns = array.GetLength(0) * array.GetLength(1);
//     for (int k = 0; k < array.GetLength(2); k++){
//         for (int i = 0; i < array.GetLength(0); i++){
//             for (int j = 0; j < array.GetLength(1); j++){
//                 Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
//                 if((j + 1 == array.GetLength(1))){
//                     Console.WriteLine();
//                 }
//             }
//         }
//         Console.WriteLine();
//     }
// }

// int[,,] GetArray(int rank1, int rank2, int rank3, int min, int max){
//     int[,,] result = new int[rank1, rank2, rank3];
//     for(int i = 0; i < rank1; i++){
//         for(int j = 0; j < rank2; j++){
//             for(int k = 0; k < rank3; k++){

//                 while(result[i,j,k] == 0){
//                     int number = new Random().Next(min, max + 1);
//                     if(CheckCopyElements(result, number)) continue;

//                     result[i,j,k] = number;
//                 }
//             }
//         }
//     }
//     return result;
// }

// bool CheckCopyElements(int[,,] array, int randomNumber){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             for(int k = 0; k < array.GetLength(2); k++){
//                 if(array[i,j,k] == randomNumber) return true;
//             }
//         }
//     }
//     return false;
// }

//==================================================================================================================================================================================