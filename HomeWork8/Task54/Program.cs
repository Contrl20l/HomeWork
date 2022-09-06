// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);
Console.WriteLine($"Получившиеся массив из введённых значений {n} строки и {m} столбца:");
PrintArray(numbers);

// Функция сортировки элементов в строке двумерного массива, по убыванию

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int v = 0; v < numbers.GetLength(1) - 1; v++)
        {
            if (numbers[i, v] < numbers[i, v + 1]) // если нужно по возрастанию, заменить знак '<' на противоложный.
            {
                int temp = 0;
                temp = numbers[i, v];
                numbers[i, v] = numbers[i, v + 1];
                numbers[i, v + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(numbers);

// Функция заполнения массива рандомно числами от 1 до 10

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Функция выввода массива в структурированном виде
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