/*
Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 2 3
4 2 4
2 6 7
*/

int[,] GeneratePositiveMatrix(int height, int width, int topEnd)
{
    int[,] generatedArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            generatedArray[i, j] = new Random().Next(0, topEnd + 1);
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
void showMatrix(int[,] inputMatrix)
{
    PrintColorData($" \t");
    for (int i = 0; i < inputMatrix.GetLength(1); i++)
    {
        PrintColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        PrintColorData($"{i}\t");
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write($"{inputMatrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] FindMinElementAddress(int[,] inputMatrix)
{
    int[] minCoordinates = new int[2];
    int minValue = inputMatrix[0, 0];
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            if (inputMatrix[i, j] < minValue)
            {
                minValue = inputMatrix[i, j];
                minCoordinates[0] = i;
                minCoordinates[1] = j;
                Console.WriteLine($"Минимальный элемент {minValue}");
            }
        }
    }
    return minCoordinates;
}

int[,] ReduceMatrix(int[,] inputMatrix, int[] minCoordinates)
{
    int[,] reducedMatrix = new int[inputMatrix.GetLength(0) - 1, inputMatrix.GetLength(1) - 1];
    for (int i = 0; i < reducedMatrix.GetLength(0); i++)
    {
        if (i == minCoordinates[0])
        {
            i++;
        }
        for (int j = 0; j < reducedMatrix.GetLength(1); j++)
        {
            if (j == minCoordinates[1])
            {
                j++;
            }
            reducedMatrix[i, j] = inputMatrix[i, j];
        }
    }
    return reducedMatrix;
}

int[,] generatedMatrix = GeneratePositiveMatrix(5, 5, 10);
showMatrix(generatedMatrix);
int[] minElementCoordinates = FindMinElementAddress(generatedMatrix);
int[,] reducedMatrix = ReduceMatrix(generatedMatrix, minElementCoordinates);
showMatrix(reducedMatrix);
