// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine() ?? "");

int i = 1;
double result = 1;

while (i <= n)
{
    result = Math.Pow(i, 3);
    Console.Write($"{result} ");
    i++;
}