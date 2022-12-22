// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите целое положительное число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = DayNumber(number);
if (res == -1)
{
    Console.WriteLine("Вы ввели число не удовлетворящее условиям");
}
else
{
    Console.WriteLine(res == 0 ? "Этот день - выходной" : "Этот день - рабочий");
}

int DayNumber(int num)
{
    int day = 1;
    if (num < 1 || num > 7)
    {
        day = -1;
    }
    else if (num == 6 || num == 7)
    {
        day = 0;
    }
    return day;
}