// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int SumOfOddElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) count = count + arr[i];
    }
    return count;
}

Console.Write("Введите длину одномерного массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение одномерного массива: ");
int minArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение одномерного массива: ");
int maxArray = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(size, minArray, maxArray);
PrintArray(array);
int sumOfOddElements = SumOfOddElements(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sumOfOddElements}");