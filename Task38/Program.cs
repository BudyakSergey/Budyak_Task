// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "; ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

double DifferenceMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    double result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    result = max - min;
    return result = Math.Round(result, 1);
}

Console.Write("Введите длину одномерного массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение одномерного массива: ");
int minArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение одномерного массива: ");
int maxArray = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArrayRndDouble(size, minArray, maxArray);
PrintArrayDouble(array);
double differenceMaxMin = DifferenceMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами этого массива = {differenceMaxMin}");