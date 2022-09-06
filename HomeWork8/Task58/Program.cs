// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2          1 5 8 5
// 5 9 2 3          4 9 4 2
// 8 4 2 4     и    7 2 2 6
// 5 2 6 7          2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine($"Первый массив размером {n} х {m}");
int[,] firstNumbers = new int[n, m];
FillArrayRandomNumbers(firstNumbers);
PrintArray(firstNumbers);

Console.WriteLine();
Console.WriteLine($"Второй массив размером {n} х {m}");
int[,] secondNumbers = new int[n, m];
FillArrayRandomNumbers(secondNumbers);
PrintArray(secondNumbers);

int[,] resultNumbers = new int[n, m];

// Функция переумножения значений в массиве 
for (int i = 0; i < firstNumbers.GetLength(0); i++)
{
    for (int j = 0; j < secondNumbers.GetLength(1); j++)
    {
         resultNumbers[i, j] = 0;
        for (int k = 0; k < firstNumbers.GetLength(1); k++)
        {
            resultNumbers[i, j] += firstNumbers[i, k] * secondNumbers[k, j]; // - Верный путь решения по УСЛОВИЯМ задачи
            //resultNumbers[i, j] = firstNumbers[i, j] * secondNumbers[i, j]; // - Неверный путь решения, если смотреть на пример.
        }
    }
}

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

// Функция вывода массива в структурированном виде
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

Console.WriteLine();
Console.WriteLine("Произведение числе в массиве будет равно следующему массиву:");

PrintArray(resultNumbers);
