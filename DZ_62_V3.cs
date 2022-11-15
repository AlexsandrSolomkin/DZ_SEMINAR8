// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//==================================================================================================================================================================================
/*
//Решение:

Console.WriteLine("Количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] arrayElements = new int[rows, columns];
int allElementsArray = arrayElements.GetLength(0) * arrayElements.GetLength(1);

int[,] array = GetArrayUpRight(arrayElements, 1, allElementsArray, rows, columns, 0, 0);
PrintArray(array);

int[,] GetArrayUpRight(int[,] array, int start, int end, int upRowsArray, int rightColumnsArray, int coordinatesElementRows, int coordinatesElementColumns){
    int end2 = end + 1;

    if(start != end){
        if(start != end2){
            while(coordinatesElementColumns < rightColumnsArray){
                array[coordinatesElementRows, coordinatesElementColumns] = start;
                start++;
                coordinatesElementColumns++;
            }
            coordinatesElementColumns--;
            coordinatesElementRows++;
            rightColumnsArray--;
        } else {
            return array;
        }
        
        if(start != end2){
            while(coordinatesElementRows < upRowsArray){
                array[coordinatesElementRows, coordinatesElementColumns] = start;
                start++;
                coordinatesElementRows++;
            }
            coordinatesElementRows--;
            coordinatesElementColumns--;
            upRowsArray--;
            //rightColumnsArray--;
        } else {
            return array;
        }

        if(start != end2){
            while(coordinatesElementColumns != -1){
                array[coordinatesElementRows, coordinatesElementColumns] = start;
                start++;
                coordinatesElementColumns--;
            }
            coordinatesElementColumns++;
            coordinatesElementRows--;
            rightColumnsArray--;
        } else {
            return array;
        }

        if(start != end2){
            while(coordinatesElementRows != -1){
                //int saveElementArray = array[coordinatesElementRows, coordinatesElementColumns];
                if(coordinatesElementRows == 0){
                    //coordinatesElementRows++;
                    // coordinatesElementColumns++;
                    //array[coordinatesElementRows, coordinatesElementColumns] = saveElementArray;
                    break;
                } else if(coordinatesElementRows > -1){
                    array[coordinatesElementRows, coordinatesElementColumns] = start;
                    start++;
                    coordinatesElementRows--;
                }
            }
            coordinatesElementRows++;
            coordinatesElementColumns++;
            upRowsArray--;
            //rightColumnsArray--;
        } 

        if(start != end2){
            GetArrayUpRight(array, start, end, upRowsArray, rightColumnsArray, coordinatesElementRows, coordinatesElementColumns);
        }
    } else {
        return array;
    }

    //Console.WriteLine($"start = {start}\nend = {end}\nupRowsArray = {upRowsArray}\nrightColumnsArray = {rightColumnsArray}\ncoordinatesElementRows = {coordinatesElementRows}\ncoordinatesElementColumns = {coordinatesElementColumns}");

    // if(start != end2){
    //     GetArrayUpRight(array, start, end, upRowsArray, rightColumnsArray, coordinatesElementRows, coordinatesElementColumns);
    // }
    return array;
}

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