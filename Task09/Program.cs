// Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99]
// 2.  и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 => {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit > secondDigit) Console.WriteLine ($"Наибольшая цифра цисла {number} => {firstDigit}");
// else Console.WriteLine ($"Наибольшая цифра цисла {number} => {secondDigit}");
// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра цисла {number} => {result}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра цисла {number} => {maxDigit}");
int MaxDigit(int number) // описание метода
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}