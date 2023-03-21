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
int[][] randomArray = GenerateRandom2DArray(5, 10);
Console.WriteLine("Random 2d array: ");
Print2DArray(randomArray);
SortElementsInRowIn2DArray(randomArray);
Console.WriteLine("Sorted: ");
Print2DArray(randomArray);
int[][] GenerateRandom2DArray(int rows, int columns, int min = 0, int max = 100)
{
    int[][] result = new int[rows][];
    for(int i =  0; i < rows; i++)
    {
        result[i] = new int[columns];
        for(int j = 0; j < columns; j++)
        {
            result[i][j] = Random.Shared.Next(min, max);
        }
    }
    return result;
}
void SortElementsInArray(int[] array)
{
    int countSorted = 0;
    for(int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1]) {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                countSorted++;
            }
        }
    }
    
}
void SortElementsInRowIn2DArray(int[][] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        SortElementsInArray(arr[i]);
    }
}
void Print2DArray(int[][] arr)
{
    for(int i = 0; i < arr.Length; i++) {
        Console.WriteLine(string.Join(", ", arr[i]));
    }
}