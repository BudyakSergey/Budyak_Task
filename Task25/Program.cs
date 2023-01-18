// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите втрое число (натуральное): ");
int degree = Convert.ToInt32(Console.ReadLine());

decimal degreeNumber = DegreeNumber(number, degree);
Console.WriteLine($"{number} в степени {degree} = {degreeNumber}");

decimal DegreeNumber(int num, int deg)
{
    decimal result = num;
    if (deg == 0) result = 1;
    if (deg < 0)
    {
        deg = deg * (-1);
        for (int i = 1; i <= deg - 1; i++)
        {
            result = result * num;         
        }
        //Console.WriteLine($"{result}"); //- для проверки расчетов
        result = 1 / result;
    return result;
    }
    else
    {
        for (int i = 1; i <= deg - 1; i++)
        {
            result = result * num;
            //Console.WriteLine($"{result}"); - для проверки расчетов
        }
        return result;
    }
}

