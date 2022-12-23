// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты двух точек в 3-х мерном пространстве");
Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X: ");
int pointFirstX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int pointFirstY = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int pointFirstZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X: ");
int pointSecondX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int pointSecondY = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int pointSecondZ = Convert.ToInt32(Console.ReadLine());


double hypotenuse = Hypotenuse (pointFirstX , pointFirstY , pointFirstZ, pointSecondX, pointSecondY, pointSecondZ);
Console.WriteLine($"Расстояние между точками = {hypotenuse} ");

double Hypotenuse (int x1, int y1, int z1, int x2, int y2, int z2)
{
        double result = Math.Round(Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2)), 2, MidpointRounding.ToZero);
        return result ;
}