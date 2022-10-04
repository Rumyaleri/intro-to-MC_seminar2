// задача 9 
// 1. выводит случайное число 


int number = new Random ().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10 - 99 => {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;
if(firstDigit == secondDigit) Console.WriteLine($"Цифры одинаковые");
else if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа  = {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа  = {secondDigit}");

// int res = Math.Max(firstDigit, secondDigit);
// Console.WriteLine($"Наибольшая цифра числа  = {res}");


