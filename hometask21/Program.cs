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

void write3dDistanceAB(int CoordinateX1, int CoordinateY1, int CoordinateZ1, int CoordinateX2, int CoordinateY2, int CoordinateZ2)
{
    double distance = Math.Sqrt(Math.Pow((CoordinateX2-CoordinateX1), 2) + Math.Pow((CoordinateY2-CoordinateY1), 2) + Math.Pow((CoordinateZ2-CoordinateZ1), 2));
    Console.WriteLine();
    Console.WriteLine($"Расстояние между двумя точками в трехмерном пространстве А[{CoordinateX1}:{CoordinateY1}{CoordinateZ1}] и B[{CoordinateX2}:{CoordinateY2}:{CoordinateZ2}] равно {distance}");
    Console.WriteLine();
}

Console.WriteLine("Введите координаты точки A [x:y:z]");
int userCoordinateX1 = getCoordinateFromUser("x: ");
int userCoordinateY1 = getCoordinateFromUser("y: ");
int userCoordinateZ1 = getCoordinateFromUser("z: ");
Console.WriteLine("Введите координаты точки B [x:y:z]");
int userCoordinateX2 = getCoordinateFromUser("x: ");
int userCoordinateY2 = getCoordinateFromUser("y: ");
int userCoordinateZ2 = getCoordinateFromUser("z: ");
write3dDistanceAB(userCoordinateX1, userCoordinateY1, userCoordinateZ1, userCoordinateX2, userCoordinateY2, userCoordinateZ2);