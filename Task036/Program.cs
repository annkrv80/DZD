/* Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.*/

Console.Clear();

int[] array = GetArray(10, -15, 15);
Console.WriteLine(String.Join(" ", array));
int oddNumberSum = GetOddNumberSum(array);
Console.WriteLine($"Сумма элеметов, стоящих на нечетных позициях равна {oddNumberSum}");



int[] GetArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

int GetOddNumberSum(int[] array)
{
    int oddNumberSum = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        oddNumberSum += array[i];

    }

    return oddNumberSum;
}

