/* 
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int checkIfDiv7 = number % 7;
int checkIfDiv23 = number % 23;

if (checkIfDiv7 == 0 && checkIfDiv23 == 0)
{
    Console.WriteLine($"Число {number} кратно 7 и 23.");
}
else
{
    Console.WriteLine($"Число {number} не является кратным одновременно 7 и 23.");
}