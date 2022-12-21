// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое целое число: ");
int numbersA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int numbersB = Convert.ToInt32(Console.ReadLine());
if (numbersA > numbersB)
{
    Console.WriteLine($"Число {numbersA} больше числа {numbersB}");
}
else if (numbersA < numbersB)
{
    Console.WriteLine($"Число {numbersB} больше числа {numbersA}");
}
else
{
    Console.WriteLine($"Число {numbersA} равно числу {numbersB}");
}