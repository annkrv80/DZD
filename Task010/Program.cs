//Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

int num = new Random().Next(100, 1000);
int a1 = num / 10;
int a2 = a1 % 10;

Console.WriteLine(num);
Console.WriteLine(a2);
