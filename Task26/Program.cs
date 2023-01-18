// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write ("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int numberOfDigits = NumberOfDigits (number);
Console.WriteLine ($"{numberOfDigits} цифр в числе {number}");

int NumberOfDigits(int digits)
{
    int count = 0;
    if(digits == 0) return count = 1;
    while (digits != 0)
    {
        digits = digits / 10;
        count = count + 1;
    }
    return count;
}
