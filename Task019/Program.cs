//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

Console.Write("Введите пятизначное число ");
string str = Console.ReadLine() ?? "";

int[] number = new int[str.Length];

void SearchPalindrome(string str)
{
    for (int i = 0; i < str.Length; i++)
    {
        number[i] = int.Parse(str[i].ToString());
    }
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.Write($"{str} палиндром");
    }
    else
    {
        Console.Write($"{str} не палиндром");
    }
}

if (str.Length == 5)
{
    SearchPalindrome(str);
}
else
{
    Console.WriteLine("Ошибка!Введите пятизначное число!");
}








