int getCoordinateFromUser(string userInformation)
{
    int  result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0") Console.WriteLine($"Введите целое число, вы вввели {userLine}"); else break;
    }
    return result;
}

void write2dDistanceAB(int CoordinateX1, int CoordinateY1, int CoordinateX2, int CoordinateY2)
{
    double distance = Math.Sqrt(Math.Pow((CoordinateX2-CoordinateX1), 2) + Math.Pow((CoordinateY2-CoordinateY1), 2));
    Console.WriteLine($"Расстояние между двумя точками в двумерном пространстве А[{CoordinateX1}:{CoordinateY1}] и B[{CoordinateX2}:{CoordinateY2}] равно {distance}");
}

Console.WriteLine("Введите координаты точки A [x:y]");
int userCoordinateX1 = getCoordinateFromUser("x: ");
int userCoordinateY1 = getCoordinateFromUser("y: ");
Console.WriteLine("Введите координаты точки B [x:y]");
int userCoordinateX2 = getCoordinateFromUser("x: ");
int userCoordinateY2 = getCoordinateFromUser("y: ");
write2dDistanceAB(userCoordinateX1, userCoordinateY1, userCoordinateX2, userCoordinateY2);