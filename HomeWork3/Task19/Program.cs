﻿// Задача 19: Условия: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Палиндром -  число, буквосочетание, слово или текст, одинаково читающееся в обоих направлениях.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
Console.WriteLine("Введите число: ");
string? number = Console.ReadLine();

void inputNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Введённое число: {number} -> да (палиндром).");
    }
    else Console.WriteLine($"Введённое число: {number} -> нет (не палиндром).");
}

if (number!.Length == 5)
{
    inputNumber(number);
}
else Console.WriteLine($"Введи правильное число");