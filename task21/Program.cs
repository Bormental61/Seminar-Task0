/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

double getDistance(int coordinateAX, int coordinateAY, int coordinateBX, int coordinateBY)
{
    double result = new int();
    result = Math.Sqrt(Math.Pow((coordinateAX - coordinateBX), 2) + Math.Pow((coordinateAY - coordinateBY), 2));
    return result;
}

int getCoordinateFromUser(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0")
        {
            Console.WriteLine($"Введите целое число, вы ввели {userLine}");
        }
        else
        {
            break;
        }
    }
    return result;
}

int userCoordinateAX = 0;
int userCoordinateAY = 0;
int userCoordinateBX = 0;
int userCoordinateBY = 0;
Console.WriteLine("Введите координаты");
userCoordinateAX = getCoordinateFromUser("Введите координату X точки А: ");
userCoordinateAY = getCoordinateFromUser("Введите координату Y точки А: ");
userCoordinateBX = getCoordinateFromUser("Введите координату X точки B: ");
userCoordinateBY = getCoordinateFromUser("Введите координату Y точки B: ");

double distance = getDistance(userCoordinateAX, userCoordinateAY, userCoordinateBX, userCoordinateBY);
Console.WriteLine($"Расстояние между точкой А [{userCoordinateAX}:{userCoordinateAY}] и точкой B [{userCoordinateBX}:{userCoordinateBY}] равно {distance}");