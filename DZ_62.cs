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

// double[,] arrayElements = new double[rows, columns];
// int allElementsArray = arrayElements.GetLength(0) * arrayElements.GetLength(1);

// double[,] array = GetArrayUpRight(arrayElements, 1, allElementsArray, rows, columns, 0, 0);
// PrintArray(array);

// double[,] GetArrayUpRight(double[,] array, int start, int end, int upRowsArray, int rightColumnsArray, int coordinatesElementRows, int coordinatesElementColumns){
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

//     upRowsArray--;
//     rightColumnsArray--;

//     if(start != end){
//         GetArrayDownLeft(array, start, end, upRowsArray, rightColumnsArray, coordinatesElementRows, coordinatesElementColumns);
//     }
//     return array;
// }

// double[,] GetArrayDownLeft(double[,] array, int start, int end, int downRowsArray, int leftColumnsArray, int coordinatesElementRows, int coordinatesElementColumns){
//     while(coordinatesElementColumns < leftColumnsArray){
//         array[coordinatesElementRows, coordinatesElementColumns] = start;
//         start++;
//         coordinatesElementColumns--;
        
//         if(start == end){
//             return array;
//         }
//     }

//     coordinatesElementRows--;
//     coordinatesElementColumns++;

//     while(coordinatesElementRows < downRowsArray){
//         array[coordinatesElementRows, coordinatesElementColumns] = start;
//         start++;

//         if(start == end){
//             return array;
//         }
//         coordinatesElementRows--;
//     }

//     downRowsArray--;
//     leftColumnsArray--;

//     if(start != end){
//         GetArrayUpRight(array, start, end, downRowsArray, leftColumnsArray, coordinatesElementRows, coordinatesElementColumns);
//     }
//     return array;
// }

// void PrintArray(double[,] Array){
//     for(int i = 0; i < Array.GetLength(0); i++){
//         for(int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i,j]} ");
//         }
//     Console.WriteLine();
//     }
// }

//==================================================================================================================================================================================

/*
int rows = 4;
int columns = 4;
int[,] arrayElements = new int[rows,columns];

int[,] array = GetArray(arrayElements, 1, rows, columns + 1,);
PrintArray(array);
*/
//Варинт 3
/*
int[,] GetArray(int[,] array, int start, int upRowsArray, int downRowsArray, int rightColumnsArray, int leftColumnsArray){
    int allElementsArray = array.GetLength(0) * array.GetLength(1);
    if(allElementsArray == start){
        return array;
    } else {
        for(int i = 0; i < array.GetLength(0); i++){
            for(int j = 0; j < array.GetLength(1); j++){
                array[i, j] = start;
                start++;

            }
        }
    }
    
    // for(int i = 0, num = 1; (i < rank1) && (num < allElementsArray); i++){
    //     for(int j = 0; (j < rank2) && (num <= allElementsArray); j++, num++){
    //         if((result[i,j] == 0) && (j == rank2--)){
    //             result[i,j] = num;
    //         }
    //     }
    // }
    // return result;
}
*/

//Варинт 2

// int[,] GetArray(int rank1, int rank2){
//     int[,] result = new int[rank1,rank2];
//     int allElementsArray = rank1 * rank2;
//     for(int i = 0, num = 1; (i < rank1) && (num < allElementsArray); i++){
//         for(int j = 0; (j < rank2) && (num <= allElementsArray); j++, num++){
//             if((result[i,j] == 0) && (j == rank2--)){
//                 result[i,j] = num;
//             }
//         }
//     }
//     return result;
// }

//Варинт 1

// int[,] GetArray(int rank1, int rank2){
//     int[,] result = new int[rank1,rank2];
//     int allElementsArray = rank1 * rank2;
//     for(int i = 0, num = 1; (i < rank1) && (num < allElementsArray); i++){
//         for(int j = 0; (j < rank2) && (num <= allElementsArray); j++, num++){
//             if((result[i,j] == 0) && ()){
//                 result[i,j] = num;
//             }
//         }
//     }
//     return result;
// }


/*
void PrintArray(int[,] Array){
    for(int i = 0; i < Array.GetLength(0); i++){
        for(int j = 0; j < Array.GetLength(1); j++){
            Console.Write($"{Array[i,j]} ");
        }
    Console.WriteLine();
    }
}
*/
//==================================================================================================================================================================================

// if(start != end2){
//         while(coordinatesElementRows != -1){
//             //int saveElementArray = array[coordinatesElementRows, coordinatesElementColumns];
//             if(coordinatesElementRows > 0){
//                 array[coordinatesElementRows, coordinatesElementColumns] = start;
//                 start++;
//                 coordinatesElementRows--;
//             } else if(coordinatesElementRows == -1){
//                 coordinatesElementRows++;
//                 // coordinatesElementColumns++;
//                 //array[coordinatesElementRows, coordinatesElementColumns] = saveElementArray;
//                 break;
//             }
//         }
//         //coordinatesElementRows++;
//         coordinatesElementColumns++;
//         upRowsArray--;
//         //rightColumnsArray--;
//     } else {
//         return array;
//     }