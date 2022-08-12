// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
// int numberB = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
// int numberA = int.Parse(Console.ReadLine()); (для доп варианта, чтобы лучше запомнить)
Console.WriteLine("введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
// int numberB = int.Parse(Console.ReadLine()); (для доп варианта, чтобы лучше запомнить)
int result = numberA;
Console.Clear();

for (int i = 1; i < numberB; i++)
{
result = result * numberA;
}
// Console.WriteLine(numberA+" в степини " + numberB + " -> " + result);
Console.WriteLine(numberA+", " + numberB + " -> " + result);
// Console.WriteLine( "Ответ:" + + result);