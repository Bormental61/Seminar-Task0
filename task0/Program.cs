/* 
Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
Например:
4 -> 16
-3 -> 9
-7 -> 49
*/

System.Console.WriteLine("Введите целое число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = userNumber * userNumber;
Console.WriteLine($"Квадрат числа {userNumber} равен {result}");
