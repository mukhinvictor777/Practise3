int getNumberFromUser(string userInformation)
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

void tableOfSquares(int number)
{
    Console.WriteLine();
    Console.WriteLine($"Таблица квадратов чисел от 1 до {number}");
    Console.WriteLine();
    for (int i = 1; i <= number; i++)
    {   
        int square = i*i;
        Console.WriteLine($"Квадрат {i}^2 = {square}");               
    }
    Console.WriteLine();
}

Console.WriteLine("Введите целое число");
int userNumber = getNumberFromUser("");
tableOfSquares(userNumber);
