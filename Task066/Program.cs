// Задайте значения M и N.
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = GetNumberFromUser("Введите целое число M: ", "Ошибка ввода");
int n = GetNumberFromUser("Введите целое число N:", "Ошибка ввода");
if (m > n)
{
    Console.WriteLine("Ошибка ввода! Первое число должно быть меньше второго!");
}
else
{
    GetSum(m, n);
    Console.WriteLine($"сумма чисел между {m} и {n} равна {GetSum(m, n)}");
}



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

int GetSum(int start, int end)
{
    if (start == end) return start;

    else return start + GetSum(start + 1, end);
}


