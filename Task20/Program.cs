// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X: ");
int pointFirstX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int pointFirstY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X: ");
int pointSecondX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int pointSecondY = Convert.ToInt32(Console.ReadLine());

double hypotenuse = Hypotenuse (pointFirstX , pointFirstY , pointSecondX, pointSecondY);
Console.WriteLine($"Расстояние между точками = {hypotenuse} ");

double Hypotenuse (int x1, int y1, int x2, int y2)
{
        double result = Math.Round(Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)), 2, MidpointRounding.ToZero);
        return result ;
}

// Math.Pow(2, 2);
// double d = Math.Sqrt(355);
// double num = 5.099873456;
// double numRound = Math.Round(num, 2, MidpointRounding.ToZero); - округлили до 2 знака после запятой
// Console.WriteLine(numRound);