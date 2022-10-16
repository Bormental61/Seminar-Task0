/*
Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
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
void PrintColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void showArray(int[,] inputArray)
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
            Console.Write($"{inputArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] ArrayDictionary(int[,] inputArray, int size)
{
    int[] result = new int[size * 2 + 1];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            result[inputArray[i, j] + size]++;
        }
    }
    return result;
}
void PrintArrayDictionary(int[] arrayDict)
{
    int size = (arrayDict.Length - 1) / 2;
    for (int i = 0; i < arrayDict.Length; i++)
    {
        if (arrayDict[i] != 0)
        {
            int lastDigit = arrayDict[i];
            if (lastDigit > 10)
            {
                while (lastDigit / 10 != 0)
                {
                    lastDigit /= 10;
                }
                lastDigit %= 10;
            }
            if (lastDigit > 1 && lastDigit < 5)
            {
                Console.WriteLine($"Элемент {i - size} встречается {arrayDict[i]} раза");
            }
            else
            {
                Console.WriteLine($"Элемент {i - size} встречается {arrayDict[i]} раз");
            }
        }

    }
}

int size = 10;
int[,] generatedArray = GenerateArray(5, 5, size);
showArray(generatedArray);
int[] arrayDict = ArrayDictionary(generatedArray, size);
PrintArrayDictionary(arrayDict);


