// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

// Метод чтения данных  с консоли

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Получившиеся массив:");

double[,] array = new double[m, n];

// Метод заполнения массива рандомными числами.
void FillArrayRandomNumbers(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

// Метод округления чисел до 1 цифры после запятой, и вывод ответа на консоль по столбам и строкам
void PrintArray (double[,] array)
{
for (int i = 0; i < m; i++)
  {
    Console.Write("[ ");
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.Write("]");
      Console.WriteLine();
  }
}

// Вывод ответа
FillArrayRandomNumbers(array);
PrintArray(array);
Console.WriteLine();