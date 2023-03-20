//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void SwapFirstStringAndLastStringInTheArray(int[,] arr)
{
    for(int j  = 0; j < arr.GetLength(1); j++)
    {
        int temp = arr[0, j];
        arr[0, j] = arr[arr.GetLength(0) - 1, j];
        arr[arr.GetLength(0) - 1, j] = temp;
    }
}
int[,] GenerateRandomArray(int rows, int columns, int min = 0, int max = 100)
{
    int[,] randomArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
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
int[,] arr = GenerateRandomArray(Random.Shared.Next(5, 7), Random.Shared.Next(5, 7));
Console.WriteLine("До замены: ");
Print2DArray(arr);
SwapFirstStringAndLastStringInTheArray(arr);
Console.WriteLine("После замены: ");
Print2DArray(arr);