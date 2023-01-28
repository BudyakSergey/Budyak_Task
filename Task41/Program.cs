// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Определите количество вводимых чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 0)
{
    Console.WriteLine($"Количество вводимых чисел должно быть больше или равно 0");

}
else
{
    int[] array = CreateArrayRndIntAndPositiveNumber(size);
    Console.WriteLine($"В данном спике {array[0]} положительных чисел");
}

int[] CreateArrayRndIntAndPositiveNumber(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    // return arr;
    int[] result = new int[1];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result[0] = result[0] + 1;
    }
    return result;
}