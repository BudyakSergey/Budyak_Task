// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Random rnd = new Random();
int sizeArray = rnd.Next(1, 9);
int[] array = CreatArray(sizeArray);
// вывод через строковую переменную
string s = string.Join(", ", array);
Console.WriteLine($"[{s}]");

// вывод через метод
PrintArray(array);

int[] CreatArray(int size)
{
    int[] arr = new int[size];
    int max = rnd.Next(1, 999);
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(0, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    // вывод последнего значения через отдельную переменную сделан для того,
    // чтобы не печатать запятую после последнего числа
    int j = arr.Length-1; 
    Console.Write(arr[j] + "]");
}