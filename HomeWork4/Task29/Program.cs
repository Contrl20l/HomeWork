// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Созданый массив из 8 чисел: ");
Console.Write("[");
int[] numbers = new int[8];

for (int i = 0; i < numbers.Length; i++)
{
  numbers[i] = new Random().Next(0, 100);
   if (i !=7)
   Console.Write(numbers[i] + ", ");
   else
   Console.Write(numbers[i]);
}

Console.Write("]");

