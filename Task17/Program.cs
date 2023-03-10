// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int pointX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int pointY = Convert.ToInt32(Console.ReadLine());

int qyarter = Qyarter(pointX, pointY);
string result = qyarter > 0 
                ? $"Указанные координаты соответсвуют {qyarter} четверти"
                : "Введены некорректные координаты";
Console.WriteLine(result);

int Qyarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
