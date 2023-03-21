//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int GetNumberOfRowWithMinimalSumIn2D(int[,] arr)
{
    int indexOfRowWIthMinimalSum = 0;
    int currentMinimalSum = int.MaxValue;//обращение к константе, содержащей максимальное значение для типа int32
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        int summ = 0;
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            summ += arr[i, j];
        }
        if(summ < currentMinimalSum)
        {
            currentMinimalSum = summ;
            indexOfRowWIthMinimalSum = i;
        }
    }
    return indexOfRowWIthMinimalSum + 1;
}
void Print2DArrayWithSummElementsOfRows(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        int summ = 0;
        for (int j = 0; j < columns; j++)
        {
            summ += arr[i, j];
            Console.Write($"{arr[i, j]} ");
        }
        Console.Write($" сумма {summ}");
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
int[,] arr = GenerateRandom2DArray(5, 7);
Print2DArrayWithSummElementsOfRows(arr);
Console.WriteLine($"{GetNumberOfRowWithMinimalSumIn2D(arr)} - строка с минимальной суммой");