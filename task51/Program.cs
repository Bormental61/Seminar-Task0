/*
Задача 51: Задайте двумерный массив. Найдите Сумма элементов главной диагонали.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

int[,] Generate2DArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i, j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twoDArray;
}
void PrintColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void Print2DArray(int[,] arrayToPrint)
{
    Console.Write("\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        PrintColorData(i + "\t");
    }
    Console.WriteLine();
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        PrintColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
void PrintTaskResult(int[] printArray)
{
    for (int i = 0; i < printArray.Length - 1; i++)
    {
        Console.Write($"{printArray[i]} + ");
    }
    Console.Write($"{printArray[printArray.Length - 1]}");
    Console.Write(" = ");
}

int[,] newGeneratedArray = Generate2DArray(5,7,1,9);
Print2DArray(newGeneratedArray);

int diagonalSum = new int();
//int diagonalArrayLength = new int();
// if (newGeneratedArray.GetLength(0) > newGeneratedArray.GetLength(1))
// {
//     diagonalArrayLength = newGeneratedArray.GetLength(1);
// }
// else
// {
//     diagonalArrayLength = newGeneratedArray.GetLength(0);
// }
int diagonalArrayLength = Math.Min(newGeneratedArray.GetLength(0), newGeneratedArray.GetLength(1));

int[] diagonalArray = new int[diagonalArrayLength]; 
for (int i = 0; i < diagonalArrayLength; i++)
{
    diagonalArray[i] = newGeneratedArray[i,i];
    diagonalSum += newGeneratedArray[i,i]; 
}
PrintTaskResult(diagonalArray);
Console.WriteLine(diagonalSum);

