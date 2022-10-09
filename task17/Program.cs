int getQuaterFromCoordinate(int CoordinateX, int CoordinateY)
{
    int result = 0;
    if (CoordinateX > 0 && CoordinateY > 0) result = 1;
    if (CoordinateX < 0 && CoordinateY > 0) result = 2;
    if (CoordinateX < 0 && CoordinateY < 0) result = 3;
    if (CoordinateX > 0 && CoordinateY < 0) result = 4;
    return result;
}

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

Console.WriteLine("Введите координаты");
int userCoordinateX = getCoordinateFromUser("X: ");
int userCoordinateY = getCoordinateFromUser("Y: ");

int quater = getQuaterFromCoordinate(userCoordinateX, userCoordinateY);

if (quater > 0)
{
    Console.WriteLine($"Точка с координатами [{userCoordinateX}:{userCoordinateY}] находится {quater} четверти" );
}
else
{
    Console.WriteLine("Невозможно определить четверть, перезапустите программу и введите координаты отличные от нуля");
}