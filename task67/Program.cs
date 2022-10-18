/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

Console.WriteLine("Input number N");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetSum(userNumber));

int GetSum(int N)
{
    if (N == 0)
    {
        return 0;
    }
    int digit = N % 10;
    return digit + GetSum(N / 10);
}
