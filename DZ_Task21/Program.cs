// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double result = Math.Sqrt((xb - xa)*(xb - xa) + (yb - ya)*(yb - ya) + (zb - za)*(zb - za));
    return result;
}

Console.WriteLine("Введите координату X точки A:");
int coord_xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A:");
int coord_ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки A:");
int coord_za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X точки B:");
int coord_xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B:");
int coord_yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B:");
int coord_zb = Convert.ToInt32(Console.ReadLine());
double dist = Distance(coord_xa, coord_ya, coord_za, coord_xb, coord_yb, coord_zb);
dist = Math.Round(dist, 2, MidpointRounding.ToZero);
Console.WriteLine($"A({coord_xa},{coord_ya},{coord_za}); B({coord_xb},{coord_yb},{coord_zb}) -> {dist}");