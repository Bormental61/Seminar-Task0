// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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

int[] GetRandomArray(int length)
{
    int[] randomArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        randomArray[i] = new Random().Next();
    }
    return randomArray;
}


int[] GetCopyArray(int[] incomingArray)
{
    int[] newArray = new int[incomingArray.Length];
    for (int i = 0; i < incomingArray.Length; i++)
    {
        newArray[i] = incomingArray[i];
    }
    return newArray;
}

void printArray(int[] arrayToPrint, string name)
{
    Console.WriteLine($"---------{name}---------");
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Привет! Эта программа создает рандомный массив, заданной длины, и создает его копию");
string userChoice = "y";
while (userChoice.ToLower() == "y")
{
    int arrayLength = GetNumberFromUser("Введите длину массива: ");
    int[] newArray = GetRandomArray(arrayLength);
    printArray(newArray, "Оригинальный новый массив");
    int[] copyArray = GetCopyArray(newArray);
    printArray(copyArray, "Копия массива");

    Console.WriteLine("Хотите повторить? Да - Y, Нет - N");
    userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
    {
        Console.WriteLine("Пожалуйста введите верное решение. Да - Y, Нет - N");
        userChoice = Console.ReadLine();
    }
}
Console.WriteLine("Пока!");