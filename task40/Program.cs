/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

// int getCoordinateFromUser(string userInformation)
// {
//     int result = 0;
//     while (result == 0 || result < 0)
//     {
//         Console.Write(userInformation);
//         string userLine = Console.ReadLine();
//         int.TryParse(userLine, out result);
//         if (result == 0 || result < 0)
//         {
//             Console.WriteLine($"Введите целое положительное число, вы ввели {userLine}");
//         }
//         else
//         {
//             break;
//         }
//     }
//     return result;
// }
// Console.Clear();
// Console.WriteLine("Введите стороны треугольника.");
// int sideA = getCoordinateFromUser("Сторона А: ");
// int sideB = getCoordinateFromUser("Сторона В: ");
// int sideC = getCoordinateFromUser("Сторона С: ");

// if (sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB)
// {
//     Console.WriteLine($" Треугольник со сторонами {sideA}, {sideB} и {sideC} может существовать.");
// }
// else
// {
//     Console.WriteLine($" Треугольник со сторонами {sideA}, {sideB} и {sideC} не может существовать.");
// }



bool CheckFigureSide(double[] numbers, int sideIndex)
{
    double sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i != sideIndex)
        {
            sum += numbers[i];
        }
    }
    bool result = sum > numbers[sideIndex];
    return result;
}

bool CheckFigure(double[] figureSides)
{
    bool result = true;
    for (int i = 0; i < figureSides.Length; i++)
    {
        result = result && CheckFigureSide(figureSides, i);
    }
    return result;
}

double[] arr = new double[3]
{
    2,2,3
};

if (CheckFigure(arr))
{
    Console.WriteLine("Это треугольник");
}
else
{
    Console.WriteLine("Это не треугольник");
}