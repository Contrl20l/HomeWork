﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("введите число N: ");
int namber = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (namber > 0)
{
    int num = namber % 10;
    namber = namber / 10;
    sum = sum + num;
}
Console.WriteLine("Сумма цифр в числе: "  + sum);


