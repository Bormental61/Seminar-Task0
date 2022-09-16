// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

System.Console.WriteLine("Ведите номер дня недели: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number == 1) System.Console.WriteLine("Понедельник");
if (number == 2) System.Console.WriteLine("Вторник");
if (number == 3) System.Console.WriteLine("Среда");
if (number == 4) System.Console.WriteLine("Четверг");
if (number == 5) System.Console.WriteLine("Пятница");
if (number == 6) System.Console.WriteLine("Суббота");
if (number == 7) System.Console.WriteLine("Воскресенье");


