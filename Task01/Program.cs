//  Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите первое целое число: ");
int NumbersA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int NumbersB = Convert.ToInt32(Console.ReadLine());

if (NumbersA == NumbersB * NumbersB)
{
    Console.WriteLine($"Число {NumbersA} является квадратом числа {NumbersB}");
}
else
{
Console.WriteLine($"Число {NumbersA} не является квадратом числа {NumbersB}");
}