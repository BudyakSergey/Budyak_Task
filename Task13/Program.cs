// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int number = new Random().Next(0, 100000000);
// Console.WriteLine($"Случайное число от 0-99999999 => {number}");
// ввод числа вручную
Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// построчный код
// при выводе исходных данных для точного понимания из какого условия
// пишутся ответ, условия пронумерованы 1, 2, 3
// int result = 0;
// if (number < 100)
// {
//     Console.WriteLine("В выбранном числе третей цифры нет");
// }
// else if (number >= 100 && number <= 999)
// {
//     Console.WriteLine($"1Третья цифра в этом чиcле = {number % 100 % 10}");
// }
// else if (number >= 1000 && number <= 9999)
// {
//     Console.WriteLine($"2Третья цифра в этом чиcле = {number / 10 % 10}");
// }
// else
// {
//     int discharge = 10;
//     while (number > 9999)
//     {
//         result = number / 100 % 10;
//         // Console.WriteLine(result + " первый результат"); // для проверки
//         number = number / discharge;
//         // Console.WriteLine(number + " "); // для проверки
//         // Console.WriteLine(result + " итоговый "); // для проверки
//     }
//     Console.WriteLine($"3Третья цифра в этом чиcле  = {result}");
// }

// через функцию

int res = ThirdGrade(number);
Console.WriteLine(res == -1 ? "В выбранном числе третей цифры нет" : $"Третья цифра в этом чиcле  = {res}");

int ThirdGrade(int num)
{
// более короткий код
// if (num >99)
// {
//     while (num > 999)
//     {
//         num = num / 10;
//     }
//     return num % 10;
// }
// else return -1;
// }

    int result = 0;
    if (num < 100)
    {
        result = -1;
    }
    else if (num >= 100 && num <= 999)
    {
        result = num % 100 % 10;
    }
    else if (num >= 1000 && num <= 9999)
    {
        result = num / 10 % 10;
    }
    else
    {
        int discharge = 10;
        while (num > 9999)
        {
            result = num / 100 % 10;
            num = num / discharge;
        }
    }
    return result;
}