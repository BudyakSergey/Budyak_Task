// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число кратность которого будем проверять: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число на кратность которого будем проверять: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число на кратность которого будем проверять: ");
int numberThird = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(BothMultiple(numberFirst, numberSecond, numberThird) ? "Да, кратно" : "Нет, не кратно");

bool BothMultiple(int num1, int num2, int num3)
{
    return num1 % num2 == 0 && num1 % num3 == 0;
}