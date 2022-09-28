/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

void printInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();    
}    
int getFactorialOfNumber(int startPoint, int endPoint)
{
    int result = 1;
    if (startPoint > endPoint)
    {
        printInConsoleWithColor($"Верхняя граница отрицательна {endPoint}", ConsoleColor.DarkYellow);
        int buff = startPoint;
        startPoint = endPoint;
        endPoint = buff;
    }
    for (int i = startPoint; i <= endPoint; i++)
    {
        result *= i;
    }
    return result;  
}
printInConsoleWithColor("Введите верхнюю границу для суммы ряда", ConsoleColor.DarkMagenta);
int userNumber = Convert.ToInt32(Console.ReadLine());
int sumOfRange = getFactorialOfNumber(1, userNumber);
Console.WriteLine($"Произведение чисел от 1 до {userNumber} = {sumOfRange}");