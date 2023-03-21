//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2
//12(0,0,0) 22(0, 0, 1)
//45(1, 0, 0) 53(1, 0, 1)
void Main()
{
    int[,,] arrayWithUniqueElements = Generate3DArrayWithoutRepeats(5, 5, 5);
    Print3DArrayWithIndexes(arrayWithUniqueElements);
}
Main();
int[,,] Generate3DArrayWithoutRepeats(int firstDeminision, int secondDeminision, int thirdDeminision)
{
    var result = new int[firstDeminision, secondDeminision, thirdDeminision];
    int counter = Random.Shared.Next(10, 200);
    int operand = Random.Shared.Next(10, 200);
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            for(int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = counter += operand;
            }
        }
    }
    return result;
}
void Print3DArrayWithIndexes(int[,,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}