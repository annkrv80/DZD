/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

Console.Clear();
int[] array = GetArray(8, 100, 1000);
Console.WriteLine(String.Join(" ", array));
int evenNumbers = CountEvenNumbers(array);
Console.WriteLine($"Четных чисел в массиве {evenNumbers}.");



int[] GetArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}


int CountEvenNumbers(int[] arr)
{
    int count=0;
    foreach(int el in arr)
    {
        if(el%2==0) count++;
    }
    return count;
}