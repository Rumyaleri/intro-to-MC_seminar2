// Задача 16. 
// Напишите программу, которая 
// 1. принимает на вход два числа и
// 2. проверяет, является ли одно число квадратом другого


Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB)
Console.Write($"число {numberA} является квадратом {numberB}");
else if (numberB == numberA * numberA)
Console.Write($"число {numberB} является квадратом {numberA}");

else 
Console.Write("нет");
