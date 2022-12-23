// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите натуральное число, больше нуля: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA <= 0) Console.WriteLine("Вы ввели число не удовлетворяющие условиям");
else TableThirdDegree(numberA);

void TableThirdDegree(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,4} | {Math.Pow(count, 3)}"); 
        count++;
    }
}
System.Console.WriteLine();