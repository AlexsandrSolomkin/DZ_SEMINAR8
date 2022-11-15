// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//==================================================================================================================================================================================

//Решение:

// Console.WriteLine("Количество строк в массиве: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Количество столбцов в массиве: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] arrayElements = new int[rows, columns];
// int allElementsArray = arrayElements.GetLength(0) * arrayElements.GetLength(1);

// int[,] array = GetArrayUpRight(arrayElements, 1, allElementsArray, rows, columns, 0, 0);
// PrintArray(array);

// int[,] GetArrayUpRight(int[,] array, int start, int end, int upRowsArray, int rightColumnsArray, int coordinatesElementRows, int coordinatesElementColumns){
//     while(coordinatesElementColumns < rightColumnsArray){
//         array[coordinatesElementRows, coordinatesElementColumns] = start;
//         start++;
//         coordinatesElementColumns++;
        
//         if(start == end){
//             return array;
//         }
//     }

//     coordinatesElementColumns--;
//     coordinatesElementRows++;
    
//     while(coordinatesElementRows < upRowsArray){
//         array[coordinatesElementRows, coordinatesElementColumns] = start;
//         start++;
//         coordinatesElementRows++;

//         if(start == end){
//             return array;
//         }
//     }

//     coordinatesElementRows--;
//     coordinatesElementColumns--;
//     upRowsArray--;
//     rightColumnsArray--;

//     if(start != end){
//         GetArrayDownLeft(array, start, end, upRowsArray, rightColumnsArray, coordinatesElementRows, coordinatesElementColumns);
//     }
//     return array;
// }

// int[,] GetArrayDownLeft(int[,] array, int start, int end, int downRowsArray, int leftColumnsArray, int coordinatesElementRows, int coordinatesElementColumns){
//     while(coordinatesElementColumns != 0){
//         array[coordinatesElementRows, coordinatesElementColumns] = start;
//         start++;
//         coordinatesElementColumns--;
        
//         if(start == end){
//             return array;
//         }
//     }

//     coordinatesElementColumns++;
//     coordinatesElementRows--;

//     while(coordinatesElementRows != 0){
//         array[coordinatesElementRows, coordinatesElementColumns] = start;
//         start++;
//         coordinatesElementRows--;

//         if(start == end){
//             return array;
//         }
//     }

//     coordinatesElementRows++;
//     coordinatesElementColumns++;
//     downRowsArray--;
//     leftColumnsArray--;

//     if(start != end){
//         GetArrayUpRight(array, start, end, downRowsArray, leftColumnsArray, coordinatesElementRows, coordinatesElementColumns);
//     }

//     return array;
// }

// void PrintArray(int[,] Array){
//     for(int i = 0; i < Array.GetLength(0); i++){
//         for(int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i,j]} ");
//         }
//     Console.WriteLine();
//     }
// }

//==================================================================================================================================================================================

//Рабочий метод:

// int[,] GetArrayUpRight(int[,] array, int start, int end, int upRowsArray, int rightColumnsArray, int coordinatesElementRows, int coordinatesElementColumns){
//     while(coordinatesElementColumns < rightColumnsArray){
//         array[coordinatesElementRows, coordinatesElementColumns] = start;
//         start++;
//         coordinatesElementColumns++;
        
//         if(start == end){
//             return array;
//         }
//     }

//     coordinatesElementRows++;
//     coordinatesElementColumns--;

//     while(coordinatesElementRows < upRowsArray){
//         array[coordinatesElementRows, coordinatesElementColumns] = start;
//         start++;

//         if(start == end){
//             return array;
//         }
//         coordinatesElementRows++;
//     }

//     return array;
// }

//==================================================================================================================================================================================


// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// int[,] array = GetArray(2, 10);
// PrintArray(array);
// Console.WriteLine("=============");
// PrintArray(ArrayTurn(array));



// int[,] GetArray(int rows, int columns){
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < columns; j++){
//             array[i,j] = new Random().Next(-100, 100);
//         }
//     }
//     return array;
// }

// int[,] ArrayTurn(int[,] array){
   
//     for (int j = 0; j < array.GetLength(1); j++){
//             int t = array[0,j];
//             array[0,j]=array[array.GetLength(0)-1,j];
//             array[array.GetLength(0)-1,j]=t;

//     }
//     return array;
// }

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.


// Задача 59: Отсортировать нечетные столбцы массива по возрастанию. Вывести массив изначальный и массив с отсортированными нечетными столбцами

