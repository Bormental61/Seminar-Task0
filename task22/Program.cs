/*
Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
int getNumberFromUser(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0")
        {
            Console.WriteLine($"Введите целое число, вы ввели {userLine}");
        }
        else
        {
            break;
        }
    }
    return result;
}
Console.Write("Введите целое число больше 0: ");
int userNumber = getNumberFromUser(" ");
int squareNumber = 1;
while (squareNumber <= userNumber)
{
    Console.Write($"{Math.Pow(squareNumber, 2)} ");
    squareNumber++;
}
