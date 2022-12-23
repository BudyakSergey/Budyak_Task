// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите целое пятизначное число, больше нуля: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA <= 9999 || numberA > 99999) Console.WriteLine("Вы ввели число не удовлетворяющие условиям");
else Console.WriteLine(Palindrome(numberA));

string Palindrome(int num)
{
    string res = "Это не палиндром";
    int firstDigit = num / 10000;
    // Console.WriteLine(firstDigit);
    int secondDigit = num / 1000 % 10;
    // Console.WriteLine(secondDigit);
    int fourthDigit = num % 100 / 10;
    // Console.WriteLine(fourthDigit);
    int fifthDigit = num % 10;
    // Console.WriteLine(fifthDigit);
    if (firstDigit == fifthDigit && secondDigit == fourthDigit) res = "Это палиндром";
    return res;
}

