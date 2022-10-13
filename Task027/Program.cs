﻿// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = Math.Abs(num1);

int digitSum = DigitSum(num2);
Console.WriteLine($"Сумма чисел в числе {num1} равна {digitSum}");

int DigitSum(int number)
{
    int sum = default;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}