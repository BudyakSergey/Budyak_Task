// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = -a;
// Console.Write($"{numbersB}, ");
while (count != a+1)
// Console.Write(numbersB);
{
    Console.Write(count + " ");
    count = count + 1;
}
