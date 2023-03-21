//это другое решение для задачи 54, но уже без использования зубчатого массива
/*
 Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
 */
//я напишу решение для зубчатого массива первым
void Print2DArray(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] GenerateRandom2DArray(int rows, int columns, int min = 0, int max = 100)
{
    int[,] randomArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            randomArray[i, j] = Random.Shared.Next(min, max);
        }
    }
    return randomArray;
}
//функция сортирует заданную строку по возрастанию в незубчатом массиве
void SortRowIn2DArray(int[,] arr, int row)
{
    for(int i = 0; i <  arr.GetLength(1); i++) {
        for(int j = 0; j <arr.GetLength(1) - i - 1; j++) {
            if (arr[row, j] > arr[row, j + 1])
            {
                int temp = arr[row, j + 1];
                arr[row, j + 1] = arr[row, j];
                arr[row, j] = temp;
            }
        }
    }
}
void Sort2DArray(int[,] arr)
{
    //здесь всё аналогично первому варианту, только надо помнить про то, что первый цикл переберает строки двумерного массива
    for(int i = 0; i <  arr.GetLength(0); i++)
    {
        SortRowIn2DArray(arr, i);
    }
}
int[,] randomArray = GenerateRandom2DArray(5, 10);
Console.WriteLine("Random array: ");
Print2DArray(randomArray);
Console.WriteLine("Sorted rows: ");
Sort2DArray(randomArray);
Print2DArray(randomArray);