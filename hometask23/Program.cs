int getNumberFromUser(string userInformation)
{
    int  result = 0;
    while (result == 0 || result < 1 || result > 1290)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 || result < 1 || result > 1290) Console.WriteLine($"Введите целое число от 1 до 1290, вы вввели {userLine}"); else break;
    }
    return result;
}

void tableOfCubes(int number)
{
    Console.WriteLine();
    Console.WriteLine($"Таблица кубов чисел от 1 до {number}");
    Console.WriteLine();
    for (int i = 1; i <= number; i++)
    {   
        int cube = i*i*i;
        Console.WriteLine($"{i}^3 = {cube}");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите целое число от 1 до 1290");
int userNumber = getNumberFromUser("");
tableOfCubes(userNumber);
