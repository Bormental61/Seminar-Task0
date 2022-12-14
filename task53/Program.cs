/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/

int[,] GenerateArray(int height, int width, int deviation)
{
    int[,] generatedArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            generatedArray[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return generatedArray;
}
bool[,] GenerateBoolArray(int height, int width)
{
    bool[,] generatedArray = new bool[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            generatedArray[i, j] = (new Random().Next(0, 2) != 0);
        }
    }
    return generatedArray;
}
void PrintColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void showArray<T>(T[,] inputArray)
{
    PrintColorData($" \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        PrintColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        PrintColorData($"{i}\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i, j].ToString()}\t");
        }
        Console.WriteLine();
    }
}
int[,] SwopRows(int[,] inputArray, int rowIndex1, int rowIndex2)
{
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        int buffer = inputArray[rowIndex1, i];
        inputArray[rowIndex1, i] = inputArray[rowIndex2, i];
        inputArray[rowIndex2, i] = buffer;

    }
    return inputArray;
}
int[,] generatedArray = GenerateArray(5, 10, 100);
showArray(generatedArray);
bool[,] generatedBoolArray = GenerateBoolArray(10, 5);
showArray(generatedBoolArray);
int[,] swopedArray = SwopRows(generatedArray, 0, generatedArray.GetLength(0) - 1);
showArray(swopedArray);
