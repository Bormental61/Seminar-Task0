/* Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет
*/

System.Console.WriteLine("Введите число А: ");
int userNumberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B");
int userNumberB = Convert.ToInt32(Console.ReadLine());
int square = userNumberB * userNumberB;
if (square == userNumberA)
{
    System.Console.WriteLine("Первое число является квадратом второго");
}
else
{
    System.Console.WriteLine("Первое число не является квадратом второго");
}

