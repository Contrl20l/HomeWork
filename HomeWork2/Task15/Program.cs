Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.Write(dayNumber);
        Console.WriteLine(" -> это день недели -> да (выходной)");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.Write(dayNumber);
        Console.WriteLine(" -> это не день недели");
    }
    else
    {
        Console.Write(dayNumber);
        Console.WriteLine(" -> Это день недели -> нет (будни)");
    }
}

CheckingTheDayOfTheWeek(dayNumber);
