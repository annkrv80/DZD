// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

Console.Write("Введите длину массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите ширину массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите высоту массива: ");
int height = int.Parse(Console.ReadLine() ?? "");

int[,,] array = GetArray(rows, columns, height, 10, 100);
PrintArray(array);

int[,,] GetArray(int m, int n, int z, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, z];
                                                                                           
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue);  
              
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]} ({i},{j},{k})\t");
            }
        }
        Console.WriteLine();
    }
}

