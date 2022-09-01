// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Чтение с консоли
Console.Clear();
Console.WriteLine("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];

Console.Clear();

// Метод заполнения массива рандомными значенями
Console.WriteLine($"Получившиеся массив из введённых значений {n} и {m}:");

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

// Вывод на консоль среднего арифметического
Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = Math.Round(avarage / n, 1); 
    
    Console.Write(avarage + "; ");
}
