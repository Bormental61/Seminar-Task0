/* Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

System.Console.WriteLine("Введите трехзначное число: ");
string number = Console.ReadLine();
System.Console.WriteLine(number[2]);

/* Альтернативная программаЖ:

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Последняя цифра {number % 10}");
*/
