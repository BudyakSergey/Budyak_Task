// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите целое число от 1 до 7: ");
string NumbersA = Console.ReadLine();
if (NumbersA == "1")
{
    Console.WriteLine($"Число {NumbersA} является Понедельником");
}
else if (NumbersA == "2")
{
    Console.WriteLine($"Число {NumbersA} является Вторником");
}
else if (NumbersA == "3")
{
    Console.WriteLine($"Число {NumbersA} является Средой");
}
else if (NumbersA == "4")
{
    Console.WriteLine($"Число {NumbersA} является Четвергом");
}
else if (NumbersA == "5")
{
    Console.WriteLine($"Число {NumbersA} является Пятницей");
}
else if (NumbersA == "6")
{
    Console.WriteLine($"Число {NumbersA} является Субботой");
}
else if (NumbersA == "7")
{
    Console.WriteLine($"Число {NumbersA} является Воскресеньем");
}
else
{
    Console.WriteLine("Не верные данные");
}