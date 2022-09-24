/* 
Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/

string getCoordinatesFromQuarter(int quarter)
{
    string result = " ";
    if (quarter == 1)
    {
        result = "Координаты: X > 0, Y > 0";
    }
    else if (quarter == 2)
    {
        result = "Координаты: X < 0, Y > 0";
    }
    else if (quarter == 3)
    {
        result = "Координаты: X < 0, Y < 0";
    }
    else if (quarter == 4)
    {
        result = "Координаты: X > 0, Y < 0";
    }
    return result;
}
int getQuarterFromUser(string userInfo)
{
    int result = 0;
    while (result == 0 || result < 1 || result > 4)
    {
        Console.Write(userInfo);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result < 1 || result > 4)
        {
            Console.WriteLine($"Введите номер четверти от 1 до 4, вы ввели {userLine}");
        }
        else
        {
            break;
        }
    }
        return result;
}
    
int userQuarter = 0;
Console.WriteLine("Введите номер четверти в координатной системе: ");
userQuarter = getQuarterFromUser("");
string coordinates = getCoordinatesFromQuarter(userQuarter);
Console.WriteLine($"Координаты точек для {userQuarter} четверти {coordinates}");
