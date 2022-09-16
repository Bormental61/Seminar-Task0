// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

System.Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int count = -number;
while (count <= number)
{
    System.Console.Write($"{count}, ");
    count++;
}