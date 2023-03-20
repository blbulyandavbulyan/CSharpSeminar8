//// Задача 57: Составить частотный словарь элементов двумерного массива.
//1, 2, 3
//4, 6, 1
//2, 1, 6

//1 встречается 3 раза
//2 встречается 2 раз
//3 встречается 1 раз
//4 встречается 1 раз
//6 встречается 2 раза
//В нашей исходной матрице встречаются элементы от 0 до 9
using System.Globalization;
///Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
int[,] GenerateRandomArray(int rows, int columns, int min = 0, int max = 100)
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
void PrintCountsOfElementsIn2DArray(int[,] arr)
{
    int[] counts = new int[10];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            counts[arr[i, j]]++;
        }
    }
    for(int i = 0; i < counts.Length; i++)
    {
        if(counts[i] > 0)Console.WriteLine($"{i} встречается {counts[i]}");
    }
}
int[,] arr =
{
    { 1, 2, 3 },
    { 4, 6, 1 },
    { 2, 1, 6 },
};
PrintCountsOfElementsIn2DArray(arr);