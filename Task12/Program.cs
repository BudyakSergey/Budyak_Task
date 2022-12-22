// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

// через код
// if (numberFirst % numberSecond == 0)
// {
//     Console.WriteLine($"{numberFirst} кратно {numberSecond}");
// }
// else
// {
//     Console.WriteLine($"{numberFirst} не кратно {numberSecond}");
//     Console.WriteLine($"отстаток от деления {numberFirst % numberSecond}");
// }

// через функцию
int result = Multiplicity(numberFirst, numberSecond);
Console.WriteLine(result == 0 ?  $"{numberFirst} кратно {numberSecond}" : $"{numberFirst} не кратно {numberSecond}, отстаток от деления {result}");

int Multiplicity(int numberFirst, int numberSecond)
{
    return numberFirst % numberSecond;
}