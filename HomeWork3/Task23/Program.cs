//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int namber = Convert.ToInt32(Console.ReadLine());

void Namber(int[] namber)
{
    int subscript = 1;
    int length = namber.Length;
    while (subscript < length)
    {
        namber[subscript] = Convert.ToInt32(Math.Pow(subscript, 3));
        subscript++;
    }
}

void PrintArray(int[] coll)
{
    int index = 1;
    int count = coll.Length;
    while (index < count)
    {
        Console.Write(coll[index] + " ");
        index++;
    // Console.Write(", ");
    }
}

int[] array = new int[namber + 1];
Namber(array);
PrintArray(array);