int getNumberFromUser(string userInformation)
{
    int  result = 0;
    while ((result == 0)||(result / 10000 < 1)||(result / 10000 > 9))
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if ((result == 0)||(userLine != "0")||(result / 10000 < 1)||(result / 10000 > 9)) Console.WriteLine($"Введите целое пятизначное число, вы вввели {userLine}"); else break;
    }
    return result;
}

void palindromCheck(int number)
{
    Console.WriteLine();
    int digit1 = number / 10000;
    int digit2 = number / 1000 % 10;
    int digit3 = number / 100 % 10;
    int digit4 = number / 10 % 10;
    int digit5 = number % 10;
    if (digit1<digit2 && digit2<digit3 && digit2==digit4 && digit1==digit5) Console.WriteLine($"{number} -> да"); else Console.WriteLine($"{number} -> нет");
    Console.WriteLine();
}

Console.WriteLine("Введите целое пятизначное число");
int userNumber = getNumberFromUser("");
palindromCheck(userNumber);