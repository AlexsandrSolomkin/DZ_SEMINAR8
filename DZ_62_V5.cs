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

void PrintArray(int[,] Array){
    for(int i = 0; i < Array.GetLength(0); i++){
        for(int j = 0; j < Array.GetLength(1); j++){
            Console.Write($"{Array[i,j]} ");
        }
    Console.WriteLine();
    }
}

int[,] GetArrayUpRight(int[,] array, int start, int end, int upRowsArray, int rightColumnsArray, int coordinatesElementRows, int coordinatesElementColumns){
    
    while(start != end){
        if((array[coordinatesElementRows, coordinatesElementColumns] == 0) && (array[coordinatesElementRows + 1, coordinatesElementColumns] == 0) && (coordinatesElementRows < rightColumnsArray)){
            array[coordinatesElementRows, coordinatesElementColumns] = start;
            start++;
            coordinatesElementColumns++;
            if(coordinatesElementRows == rightColumnsArray){
                coordinatesElementColumns--;
                coordinatesElementRows++;
                rightColumnsArray--;
            }
        } else if((array[coordinatesElementRows, coordinatesElementColumns] == 0) && (array[coordinatesElementRows, coordinatesElementColumns - 1] == 0) && (coordinatesElementRows < upRowsArray)){
            array[coordinatesElementRows, coordinatesElementColumns] = start;
            start++;
            coordinatesElementRows++;
            if(coordinatesElementRows == upRowsArray){
               coordinatesElementRows--;
               coordinatesElementColumns--;
               upRowsArray--; 
            }
        } else if((array[coordinatesElementRows, coordinatesElementColumns] == 0) && (array[coordinatesElementRows - 1, coordinatesElementColumns] == 0) && (coordinatesElementRows < upRowsArray)){
            array[coordinatesElementRows, coordinatesElementColumns] = start;
            start++;
            coordinatesElementColumns--;
            if(coordinatesElementRows == 0){
                coordinatesElementColumns++;
                coordinatesElementRows--;
                rightColumnsArray--;
            }
        } else if((array[coordinatesElementRows, coordinatesElementColumns] == 0) && (array[coordinatesElementRows, coordinatesElementColumns + 1] == 0) && (coordinatesElementRows > -1)){
            array[coordinatesElementRows, coordinatesElementColumns] = start;
            start++;
            coordinatesElementRows--;
            if(coordinatesElementRows == 0){
                coordinatesElementRows++;
                coordinatesElementColumns++;
                upRowsArray--;
            }
        } else {
            break;
        }
    }
    
    //int end2 = end + 1;
    
        if((start != end) && (array[coordinatesElementRows, coordinatesElementColumns] == 0) && (array[coordinatesElementRows + 1, coordinatesElementColumns] == 0)){
            while(coordinatesElementColumns < rightColumnsArray){
                if(coordinatesElementRows == rightColumnsArray){
                    break;
                } else if(coordinatesElementRows < rightColumnsArray){
                    array[coordinatesElementRows, coordinatesElementColumns] = start;
                    start++;
                    coordinatesElementColumns++;
                }
            }
            coordinatesElementColumns--;
            coordinatesElementRows++;
            rightColumnsArray--;
        } else {
            return array;
        }
        
        // PrintArray(array);
        // Console.WriteLine("===========");
        
        // if((start != end) && (array[coordinatesElementRows, coordinatesElementColumns] == 0) && (array[coordinatesElementRows, coordinatesElementColumns - 1] == 0)){
        //     while(coordinatesElementRows < upRowsArray){
        //         if(coordinatesElementRows == upRowsArray){
        //             break;
        //         } else if(coordinatesElementRows < upRowsArray){
        //             array[coordinatesElementRows, coordinatesElementColumns] = start;
        //             start++;
        //             coordinatesElementRows++;
        //         }
        //     }
        //     coordinatesElementRows--;
        //     coordinatesElementColumns--;
        //     upRowsArray--;
        // } else {
        //     return array;
        // }
        
        // PrintArray(array);
        // Console.WriteLine("===========");

        // if((start != end2) && (array[coordinatesElementRows, coordinatesElementColumns] == 0) && (array[coordinatesElementRows - 1, coordinatesElementColumns] == 0)){
        //     while(coordinatesElementColumns != -1){
        //         if(coordinatesElementRows == 0){
        //             break;
        //         } else if(coordinatesElementRows > -1){
        //             array[coordinatesElementRows, coordinatesElementColumns] = start;
        //             start++;
        //             coordinatesElementColumns--;
        //         }
        //     }
        //     coordinatesElementColumns++;
        //     coordinatesElementRows--;
        //     rightColumnsArray--;
        // } else {
        //     return array;
        // }
        
        // PrintArray(array);
        // Console.WriteLine("===========");

        // if((start != end2) && (array[coordinatesElementRows, coordinatesElementColumns] == 0) && (array[coordinatesElementRows, coordinatesElementColumns + 1] == 0)){
        //     while(coordinatesElementRows != -1){
        //         if(coordinatesElementRows == 0){
        //             break;
        //         } else if(coordinatesElementRows > -1){
        //             array[coordinatesElementRows, coordinatesElementColumns] = start;
        //             start++;
        //             coordinatesElementRows--;
        //         }
        //     }
        //     coordinatesElementRows++;
        //     coordinatesElementColumns++;
        //     upRowsArray--;
        // }

        // PrintArray(array);
        // Console.WriteLine("===========");

        // if(start != end2){
        //     GetArrayUpRight(array, start, end, upRowsArray, rightColumnsArray, coordinatesElementRows, coordinatesElementColumns);
        // }
    //Console.WriteLine($"start = {start}\nend = {end}\nupRowsArray = {upRowsArray}\nrightColumnsArray = {rightColumnsArray}\ncoordinatesElementRows = {coordinatesElementRows}\ncoordinatesElementColumns = {coordinatesElementColumns}");

    return array;
}
*/
//==================================================================================================================================================================================