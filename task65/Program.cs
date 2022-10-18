/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

Console.WriteLine("Input start number M");
int userNumberStart = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input End number N");
int userNumberEnd = Convert.ToInt32(Console.ReadLine());

PrintRange(userNumberStart, userNumberEnd);

void PrintRange(int Start, int End)
{
    if (End < Start)
    {
        return;
    }
    PrintRange(Start, End - 1);
    Console.Write($"{End}, ");
}