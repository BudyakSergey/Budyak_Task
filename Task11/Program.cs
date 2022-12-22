// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число от 100-999 => {number}");
// int numberA = number/100;
// Console.WriteLine($"Сотня от числа {number} = {numberA}");
// int numberB = number % 100;
// int numberC = numberB % 10;

// Console.WriteLine($"Сотня от числа {number} = {numberC}");
// int result = numberA*10+numberC;
// Console.WriteLine(result);


int maxDigit = Itog(number);
 Console.WriteLine(maxDigit);

int Itog(int number) // описание метода
{
    int numberA = number / 100;
    int numberC = number % 10;
    int result = numberA*10+numberC;
    return result;
}