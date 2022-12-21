// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
Console.Write("Введите целое число для вычисления его квадрата: ");
int NumbersA = Convert.ToInt32(Console.ReadLine());
int square = NumbersA * NumbersA;
Console.WriteLine($"Квадрат числа {NumbersA} = {square}");