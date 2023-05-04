//  Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int size = GetUserNumber("Введите количество чисел: ", "Ошибка ввода");
int[] array = GetArray(size);
int result = GetPositiveNumber(array);
Console.Write(String.Join(" ", array));
Console.Write($" -> {result}");
int GetPositiveNumber(int[] array)
{
    int count=0;
    foreach (int el in array )
    {
        if (el>0) count ++;
    }
    return count;
}
int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=GetUserNumber("Введите число: ", "Ошибка ввода");
    }
    return array;
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