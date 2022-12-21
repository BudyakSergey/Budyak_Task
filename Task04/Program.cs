// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите первое целое число: ");
int numbersA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int numbersB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int numbersC = Convert.ToInt32(Console.ReadLine());
int max = numbersA;
if (numbersB>max)
{
    max = numbersB;
}
if (numbersC > max)
{
    max = numbersC;
}
Console.WriteLine($"Максимальное из введенных числе равно {max}");
