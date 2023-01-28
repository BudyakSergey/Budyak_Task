// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задайте коэффициенты первой прямой, которая описана уровнением y = k1 * x + b1: ");
Console.Write("Задайте коэффициент k1: ");
int coefficientK1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте коэффициент b1: ");
int coefficientB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте коэффициенты второй прямой, которая описана уровнением y = k2 * x + b2: ");
Console.Write("Задайте коэффициент k2: ");
int coefficientK2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте коэффициент b2: ");
int coefficientB2 = Convert.ToInt32(Console.ReadLine());


if (coefficientK2 - coefficientK1 == 0)
{
    Console.WriteLine("Эти прямые не пересекаются");
    return;
}


double[] intersectionPoint = IntersectionPoint(coefficientK1, coefficientB1, coefficientK2, coefficientB2);
Console.Write("Точка пересечения прямых - ");
PrintArray(intersectionPoint);


double[] IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double[] result = new double[2];
    result[0] = Math.Round((b1 - b2) / (k2 - k1), 2, MidpointRounding.ToZero);
    result[1] = Math.Round((k1 * result[0] + b1), 2, MidpointRounding.ToZero);
    return result;
}


void PrintArray(double[] arr)
{
    Console.Write("(");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine(")");
}