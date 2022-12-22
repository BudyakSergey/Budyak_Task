// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Write("Введите целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = numberA % 2;
// Console.Write($"{numberB}");
if (numberB == 0)
{
    Console.Write($"Число {numberA} четное");
}
else
{
     Console.Write($"Число {numberA} не четное");
}