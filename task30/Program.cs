/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

/*
int[] binarArray = new int[8];
for (int i = 0; i < binarArray.Length; i++)
{
    binarArray[i] = new Random().Next(0, 2);
}
//Array.ForEach(binarArray, Console.Write);

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}
printArray(binarArray);
*/

int RandomNum(int min, int max)
{
    int num = new Random().Next(min, max + 1);
    return num;
}

void PrintArray(int[] collection)
{
    Console.Write("[");
    for (int index = 0; index < collection.Length - 1; index++)
    {
        Console.Write($"{collection[index]},");
    }
    Console.Write($"{collection[collection.Length - 1]}");
    Console.WriteLine("]");
}

Console.Clear();
Console.WriteLine("Приветствую! Эта программа поможет создать массив из 8 элементов, заполненный нулями и единицами в случайном порядке");
string userChoice = "y";
while (userChoice.ToLower() == "y")
{
    int[] arr = new int[8];
    for (int i = 0; i < 8; i++)
    {
        arr[i] = RandomNum(0, 1);
    }
    PrintArray(arr);

    Console.WriteLine("Вы хотите продолжить работу с программой? Да - Y, Нет - N");
    userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
    {
        Console.WriteLine("Пожалуйста, введите верное решение. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
        userChoice = Console.ReadLine();
    }
}
Console.WriteLine("Bye!");