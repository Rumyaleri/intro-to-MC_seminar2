int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число {number}");
int firstDigit = number / 100;
    int secondDigit = number / 10;
    int thirdDigit = number % 10;

Console.WriteLine($"{firstDigit}{thirdDigit}");


// int MaxDigit(int number)
// {
//     int firstDigit = number / 100;
//     int secondDigit = number / 10;
//     int thirdDigit = number % 10;
//     if (firstDigit > secondDigit) return firstDigit;
//     return secondDigit;
// }
