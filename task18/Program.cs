string getCoordinateXFromQuater(int userQuater)
{
    string result = string.Empty;
    if (userQuater == 1 || userQuater == 4) result = "от 0 до + бесконечности, при этом x не равно 0";
    if (userQuater == 2 || userQuater == 3) result = "от - бесконечности до 0, при этом x не равно 0";
    return result;
}

string getCoordinateYFromQuater(int userQuater)
{
    string result = string.Empty;
    if (userQuater == 1 || userQuater == 2) result = "от 0 до + бесконечности, при этом y не равно 0";
    if (userQuater == 3 || userQuater == 4) result = "от - бесконечности до 0, при этом y не равно 0";
    return result;
}

int getQuaterFromUser(string userInformation)
{
    int  result = 0;
    while (result == 0)
    {
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0) 
        {
            Console.WriteLine($"Четверти < {userLine} > не существует");
            Console.WriteLine("Введите целое число от 1 до 4");
        }
        else break;
    }
     while (result > 4)
    {
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result > 4) 
        {
            Console.WriteLine($"Четверти < {userLine} > не существует");
            Console.WriteLine("Введите целое число от 1 до 4");
        }
        else break;
    }
        while (result < 1)
    {
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result < 1) 
        {
            Console.WriteLine($"Четверти <{userLine}> не существует");
            Console.WriteLine("Введите целое число от 1 до 4");;
        }
        else break;
    }
    return result;    
}

Console.WriteLine("Введите номер четверти от 1 до 4");
int userQuater = getQuaterFromUser("Номер четверти: ");
string coordinateX = getCoordinateXFromQuater(userQuater);
string coordinateY = getCoordinateYFromQuater(userQuater);
Console.WriteLine();
Console.WriteLine($"Четверти {userQuater} принадлежат значения по оси X: {coordinateX}");
Console.WriteLine($"Четверти {userQuater} принадлежат значения по оси Y: {coordinateY}");
Console.WriteLine();