// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

Console.Write("Введите число строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 50);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Cтрокa с наименьшей суммой элементов {GetMinSumRows(array)}");


//////////////////////////////////////////////////////////////
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int GetMinSumRows(int[,] inArray)
{
    int row = 0;
    int minsum = 0;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        minsum = minsum + inArray[0, i];
    }

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum = sum + inArray[i, j];
        }
        Console.WriteLine($"{sum}");

        if (minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}






