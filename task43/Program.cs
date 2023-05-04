// Напишите программу, которая найдёт точку пересечения двух прямых
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.​
int k1 = GetUserNumber("Введите коэффициент к1: ", "Ошибка ввода");
int b1 = GetUserNumber("Введите коэффициент b1: ", "Ошибка ввода");
int k2 = GetUserNumber("Введите коэффициент к2: ", "Ошибка ввода");
int b2 = GetUserNumber("Введите коэффициент b2: ", "Ошибка ввода");
int x = GetX(k1, b1, k2, b2);
int y = GetY(k1, b1, x);

Console.WriteLine($"y = {k1}*x + {b1} , y = {k2}*x + {b2} -> ({x},{y})");

int GetY(int k1, int b1, int x)
{
    int result = k1 * x + b1;
    return result;
}

int GetX(int k1, int b1, int k2, int b2)
{
    int result = 0;
    result = (b2 - b1) / (k1 - k2);
    return result;
}


int GetUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}