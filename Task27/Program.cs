// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write ("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int numberOfDigits = NumberOfDigits (number);
Console.WriteLine ($"Сумма цифр числа {number} =  {numberOfDigits}");

int NumberOfDigits(int digits)
{
    int count = 0;
    int remainder = 0;
    if(digits == 0) return count = digits;
    while (digits != 0)
    {
        remainder = digits % 10;
        digits = digits / 10;
        count = count + remainder;
    }
    return count;
}


