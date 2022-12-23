// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.


Console.WriteLine("Введите натуральное число, больше нуля: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA <= 0) Console.WriteLine("Вы ввели число не удовлетворяющие условиям");
else TableSquare(numberA);

void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        // Console.WriteLine($"{count} в квадрате {Math.Pow(count, 2)}");
        // count = count + 1;
        Console.WriteLine($"{count, 4} {Math.Pow(count, 2), 4}");
        count ++;
    }
}
System.Console.WriteLine();