Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number >= 999)
{
    number = number / 10;
}
int findDigit = number % 10;
Console.WriteLine($"Третья цифра числа: {findDigit}");