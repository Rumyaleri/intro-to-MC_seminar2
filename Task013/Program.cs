Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
while (number >= 999)
{
    number = number / 10;
}
int findDigit = number % 10;
Console.WriteLine($"Третья цифра числа: {findDigit}");
}
else 
Console.WriteLine($"Третья цифра отсутствует");

