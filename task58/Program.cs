//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, заданы 2 массива:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//и
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7
//Их произведение будет равно следующему массиву:
//1 20 56 10
//20 81 8 6
//56 8 4 24
//10 6 24 49
using task58;
void Main()
{
    const int ROWS = 5;
    const int COLUMNS = 7;
    int[,] arr1 = GenerateRandom2DArray(ROWS, COLUMNS);
    int[,] arr2 = GenerateRandom2DArray(ROWS, COLUMNS);
    Console.WriteLine("первый массив: ");
    Print2DArray(arr1);
    Console.WriteLine("второй массив: ");
    Print2DArray(arr2);
    Console.WriteLine("Произведение: ");
    Print2DArray(GetProductOfTwoMatrix(arr1, arr2));
}
Main();
int[,] GetProductOfTwoMatrix(int[,] m1, int[,] m2)
{
    if(m1.GetLength(0) != m2.GetLength(0) || m1.GetLength(1) != m2.GetLength(1))
    {
        throw new MatrixsSizesAreNotEqualException("размеры матрицы не равны");
    }
    int[,] result = new int[m1.GetLength(0), m1.GetLength(1)];
    for(int i = 0; i  < m1.GetLength(0); i++)
    {
        for(int j = 0; j < m1.GetLength(1); j++)
        {
            result[i, j] = m1[i, j] * m2[i, j];
        }
    }
    return result;
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