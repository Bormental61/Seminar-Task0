/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
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
int countNumberOfElenentsInRange(int[] incomingArray, int minBorder, int maxBorder)
{
    int count = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] >= minBorder && incomingArray[i] <= maxBorder)
        count += 1;
    }
    return count;
}
int[] currentArray = getRandomArray(123, 0, 999);
printArray(currentArray);
int numberOfElementsInRange = countNumberOfElenentsInRange(currentArray, 10, 99);
Console.WriteLine($"В массиве присутствуют {numberOfElementsInRange} элементов в диапазоне [10:99");