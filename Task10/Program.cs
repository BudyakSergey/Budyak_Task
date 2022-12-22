// 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число от 100-999 => {number}");

// int numberB = number/10 % 10;
// Console.WriteLine($"Десток от числа {number} = {numberB}");

int secondDigit = SecondDigit(number);
Console.WriteLine($"Вторая цифра в этом чиcле = {secondDigit}");

int SecondDigit(int num) 
{
    int result = num/10 % 10;
    return result;
}