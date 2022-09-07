// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Clear();

int m = GetNumberFromUser("Введите целое число M: ", "Ошибка ввода");
int n = GetNumberFromUser("Введите целое число N:", "Ошибка ввода");
if (m > n)
{
    Console.WriteLine("Ошибка ввода! Первое число должно быть меньше второго!");
}
else
{
    PrintNumber(m, n);
}

/////////////////////////////////////////////////////////////////////

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

void PrintNumber(int start, int end)
{
    if (start == end + 1) return;
    if (start == end)
    {
        Console.Write(start + ".");
    }
    else
    {
        Console.Write(start + ",");
    }
    
    PrintNumber(start + 1, end);
}