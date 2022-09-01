// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Ввод размера массива с консоли
Console.WriteLine("Размер строки массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер столбеца массива:");
int b = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[a, b];

// Ввод позиции значения в массиве
Console.WriteLine("Введите строку: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец:");
int m = Convert.ToInt32(Console.ReadLine());

// Или определение размера массива 10х10
// int[,] numbers = new int[10, 10];

// Метод заполнения массива рандомными значенями

Console.Clear();

Console.WriteLine("Получившиеся массив:");

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);  // Значения в массиве от 0 до 10
        }
    }
}

FillArrayRandomNumbers(numbers);

// метод придания массиву структурированного вида
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

PrintArray(numbers);
// Метод определяет, есть ли значение в массиве или нет

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
}
