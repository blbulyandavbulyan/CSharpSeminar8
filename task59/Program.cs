//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Наименьший элемент - 1, на выходе получим 
//следующий массив:
//9 4 2
//2 2 6
//3 4 7
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
int[,] GetArrayWithoutRowAndColumnWhereIsAMinimalElement(int[,] arr)
{
    int[,] result = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int minimum = arr[0, 0];
    int columnOfMinimum = 0, rowOfMinimum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < arr[rowOfMinimum, columnOfMinimum])
            {
                rowOfMinimum = i;
                columnOfMinimum = j;
            }
                
        }
    }
    int resultColumn = 0, resultRow = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if (i != rowOfMinimum && j != columnOfMinimum)
            {
                result[resultRow, resultColumn++] = arr[i, j];
            }
        }
        if (i != rowOfMinimum) resultRow++;
        resultColumn = 0;
    }
    return result;
}
int[,] randomArray = GenerateRandomArray(5, 3, 10);
Print2DArray(randomArray);
int[,] modifedArray = GetArrayWithoutRowAndColumnWhereIsAMinimalElement(randomArray);
Console.WriteLine();
Print2DArray(modifedArray);