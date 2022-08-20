// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

int num1 = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");
int num2 = GetNumberFromUser("Введите целое число В: ", "Ошибква ввода!");
int result = Exponentiation(num1);

Console.WriteLine($"\t {num1} в степени {num2} равно {result}");



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

int Exponentiation(int rank)
{
    rank = 1;
    int count = 0;
    while (count < num2)
    {
        rank = rank * num1;
        count++;
    }
    return rank;
}



