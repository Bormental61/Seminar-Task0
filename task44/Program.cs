/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

void PrintInConsoleWithColor(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(message);
    Console.ResetColor();
}

int GetNumberFromUser(string userInformation)
{
    int result;
    PrintInConsoleWithColor($"{userInformation}: ", ConsoleColor.DarkBlue);
    while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
    {
        PrintInConsoleWithColor($"Ошибка ввода! Ожидается число больше нуля. {userInformation}: ", ConsoleColor.DarkYellow); ;
    }
    return result;
}

int[] getFibonacciArray(int number)
{
    int[] FArray = new int[number];
    FArray[0] = 0;
    FArray[1] = 1;
    for (int i = 2; i < number; i++)
    {
        FArray[i] = FArray[i - 1] + FArray[i - 2];
    }
    return FArray;
}

void printFArray(int[] arrayToPrint, string name)
{
    Console.WriteLine($"---------{name}---------");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write($"{arrayToPrint[i]} ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Привет! Эта программа выводит первые N чисел последовательности Фибоначчи");
string userChoice = "y";
while (userChoice.ToLower() == "y")
{
    int numberN = GetNumberFromUser("Введите чсло N: ");
    int[] FibonacciArray = getFibonacciArray(numberN);
    printFArray(FibonacciArray, $"Последовательность Фибоначчи для {numberN} чисел");

    Console.WriteLine("Хотите повторить? Да - Y, Нет - N");
    userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
    {
        Console.WriteLine("Пожалуйста введите верное решение. Да - Y, Нет - N");
        userChoice = Console.ReadLine();
    }
}
Console.WriteLine("Пока!");