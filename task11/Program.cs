﻿/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления. 
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int devLast = number1 % number2;
if (devLast > 0) Console.WriteLine($"Второе число не кратно первому, остаток {devLast}.");
else Console.WriteLine("Второе число кратно первому.");
