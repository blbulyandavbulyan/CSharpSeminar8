//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
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
int[,] SwapRowsAndColumns(int[,] arr)

{
    int[,] result = new int[arr.GetLength(1), arr.GetLength(0)];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            result[j, i] = arr[i, j];
        }
    }
    return result;
}
void SwapRowsAndColumnsIfRowsAndColumnsCountAreEqueal(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = i; j < arr.GetLength(1); j++)
        {
            int temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    }
}
int[,] arr = GenerateRandomArray(5, 5, 10, 99);
Console.WriteLine("Неперевернутый массив: ");
Print2DArray(arr);
SwapRowsAndColumnsIfRowsAndColumnsCountAreEqueal(arr);
Console.WriteLine("Перевёрнутый массив: ");
Print2DArray(arr);