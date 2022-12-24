// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


// Console.Write("Введите количество строк массива:");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива:");
// int d1 = Convert.ToInt32(Console.ReadLine());

// int[,] GetArray(int row, int column)
// {
//     int[,] temparray = new int[row, column];
//     for (int i = 0; i < temparray.GetLength(0); i++)
//     {
//         for (int j = 0; j < temparray.GetLength(1); j++)
//         {
//             temparray[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return temparray;
// }
void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// void ChangeArray(int[,] comparray)
// {
//    // int[] tempArray = new int[comparray.GetLength(1)];
//     int temper = 0;
//     for (int j = 0; j < comparray.GetLength(1); j++)
//     {
//         temper = comparray[0, j];
//         comparray[0, j] = comparray[comparray.GetLength(0) - 1, j];
//         comparray[comparray.GetLength(0) - 1, j] = temper;
//     }

// }
// int[,] doub = GetArray(b1, d1);
// PrintArray(doub);
// ChangeArray(doub);
// PrintArray(doub);

//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Write("Введите количество строк массива:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива:");
int d1 = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int row, int column)
{
    int[,] temparray = new int[row, column];
    for (int i = 0; i < temparray.GetLength(0); i++)
    {
        for (int j = 0; j < temparray.GetLength(1); j++)
        {
            temparray[i, j] = new Random().Next(1, 10);
        }
    }
    return temparray;
}

// int[,] ChangeArray(int[,] comparray)
// {
//     int[,] tempArray = GetArray(comparray.GetLength(0), comparray.GetLength(1));
//     if (comparray.GetLength(0) == comparray.GetLength(1))
//     {
//         for (int i = 0; i < comparray.GetLength(0); i++)
//         {
//             for (int j = 0; j < comparray.GetLength(1); j++)
//             {
//                 tempArray[j, i] = comparray[i, j];
//             }
//         }
//     }
//     else
//     {
//         Console.WriteLine($"Кол-во строк {comparray.GetLength(0)} не соответствуе кол-ву столбцов{comparray.GetLength(1)}");
//     }
//     return tempArray;
// }


// int[,] doub = GetArray(b1, d1);
// PrintArray(doub);
// PrintArray(ChangeArray(doub));


// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

// Console.Write("Введите количество элементов массива:");
// int [] searchArray = new int [Convert.ToInt32(Console.ReadLine())];
// for(int i = 0; i < searchArray.GetLength(0); i++)
// {
//     searchArray[i] = new Random().Next(0,10);
    
// }

// int [,] CheckArray(int[] array)
// {
//     int[,] wert = new int [2,10];
//     for(int i = 0; i < 10; i++)
//     {
//         wert[0,i] = i;
//     }

//     for(int j = 0; j < array.GetLength(0);j++)
//     {
//         wert[1,array[j]]++;
//     }
//     return wert;
// }   
// void PrintArray1D(int[] numbers)

// {
//     for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         Console.Write(numbers[i] + " ");
        
       
//     }
//     Console.WriteLine();
// }
// PrintArray1D(searchArray);
// Console.WriteLine();
// // CheckArray(searchArray);
// PrintArray(CheckArray(searchArray));

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] DeleteArray (int[,] array)
{
    int minValue = array[0,0];
    int minValueRowIndex = 0;
    int minValueColumnIndex = 0;
    for(int i =0 ; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < minValue)
            {
                minValue = array [i,j];
                minValueRowIndex = i;
                minValueColumnIndex = j;
            }
        }
    }
     for(int i =0 ; i < array.GetLength(0); i++)
    {
        array[i,minValueColumnIndex] = -1;

    }
    for(int j =0 ; j < array.GetLength(1); j++)
    {
        array[minValueRowIndex,j] = -1;
        
    }
    return array;
}
int [,] result = GetArray(b1,d1);
PrintArray(result);
Console.WriteLine();
PrintArray(DeleteArray(result));
