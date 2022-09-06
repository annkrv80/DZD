// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();

Console.Write("Введите размерность матриц (nxn): ");
int rows = int.Parse(Console.ReadLine() ?? "");
int columns = rows;
int[,] array1 = GetArray(rows, columns, 0, 50);
int[,] array2 = GetArray(rows, columns, 0, 50);

PrintArray(array1);
Console.WriteLine();
PrintArray(array2);

Console.WriteLine();
int[,] twoMatrices=MultipTwoMatrices(array1,array2);
PrintArray(twoMatrices);

/////////////////////////////////////////////////////////////
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

int[,] MultipTwoMatrices(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                result[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return result;
}