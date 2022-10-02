/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

int[] getRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}
void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
bool findNumberinArray(int[] incomingArray, int number)
{
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (Math.Abs(incomingArray[i]) == Math.Abs(number))
        {
            return true;
        }

    }
    return false;
}

Console.Clear();
int[] currentArray = getRandomArray(4, -9, 9);
printArray(currentArray);
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

bool IsNumberInArray = findNumberinArray(currentArray, userNumber);
Console.WriteLine($"Элемент {userNumber} {((IsNumberInArray) ?"":"не")} присутствует в массиве");