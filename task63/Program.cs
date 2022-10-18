/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

Console.WriteLine("Введите число N");
int userNumber = Convert.ToInt32(Console.ReadLine());
PrintRange(userNumber);

void PrintRange(int N)
{
    if (N == 0)
    {
        return;
    }
    PrintRange(N - 1);
    Console.Write($"{N}, ");
}