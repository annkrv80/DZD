// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();

int num = GetNumberFromUser("Введите целое число:", "Ошибка вводаI");
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
   }

}
int result = SumDigits(num);

int SumDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }

    return sum;

}

Console.WriteLine($"сумма цифр число {num} равна {result}");