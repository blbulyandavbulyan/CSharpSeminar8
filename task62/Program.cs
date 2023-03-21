//Задача 62. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//1   2 3  4
//12 13 14 5
//11 16 15 6
//10 9 8   7

void Main()
{
    Print2DArray(GenerateSpiralArray(4));
}
Main();
//функция начинает заполнение квадрата с верхнего левого угла
int FillSquareIn2D(int[,] arr, int startI, int startJ, int startCounterValue)
{
    //порядок таков, верх, право, низ, лево
    //прежде всего давайте посчитаем четыре точки нашего заполняемого квадрата(4 угла)

    IndexIn2DArray topLeft = new IndexIn2DArray(startI, startJ);
    IndexIn2DArray topRight = new IndexIn2DArray(startI, arr.GetLength(1) - startJ - 1);
    IndexIn2DArray bottomRight = new IndexIn2DArray(arr.GetLength(0) - startI - 1, arr.GetLength(1) - startJ - 1);
    IndexIn2DArray bottomLeft = new IndexIn2DArray(arr.GetLength(0) - startI - 1, startJ);
    int counter = startCounterValue;
    //заполняем верхнию строку нашего переданного квадрата
    for (int j = topLeft.j; j <= topRight.j; j++)
    {
        arr[startI, j] = counter++;
    }
    //заполняем правый столбец нашего квадрата
    //смещаемся на одну строку вниз вначале, т.к. в верхней строке у нас уже есть числа
    for(int i = topRight.i + 1; i <= bottomRight.i; i++)
    {
        arr[i, topRight.j] = counter++;
    }
    //заполняем нижнюю строку нашего квадрата
    //смещаемся на 1 влево, т.к. у нас в правом столбце уже есть числа
    for (int j = bottomRight.j - 1; j >= bottomLeft.j; j--)
    {
        arr[bottomLeft.i, j]= counter++;
    }
    //заполняем левый столбец нашего квадрата
    //смещаемся на 1 вверх, т.к. нижняя строка у нас уже заполнена
    //здесь знак меньше, поскольку верхняя строка у нас уже заполнена
    for(int i = bottomLeft.i - 1; i > topLeft.i; i--)
    {
        arr[i, bottomLeft.j] = counter++;
    }
    return counter;
}
int[,] GenerateSpiralArray(int countOfRowsAndColumns)
{
    int[,] result = new int[countOfRowsAndColumns, countOfRowsAndColumns];
    //в этом цикле мы просто будем идти по главной диагонале нашего квадрата
    int counter = 1;
    for(int i = 0; i <= countOfRowsAndColumns/2; i++)
    {
        counter = FillSquareIn2D(result, i, i, counter);
    }
    if (countOfRowsAndColumns % 2 != 0) { 
        result[countOfRowsAndColumns / 2, countOfRowsAndColumns / 2] = result[countOfRowsAndColumns/2, countOfRowsAndColumns/2 - 1] + 1; 
    }
    return result;
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
struct IndexIn2DArray
{
    public int i;
    public int j;
    public IndexIn2DArray(int i, int j)
    {
        this.i = i;
        this.j = j;
    }
    public IndexIn2DArray() { }
}