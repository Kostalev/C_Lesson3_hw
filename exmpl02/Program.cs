// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Double x1, x2, y1, y2, z1, z2, dif;

Console.Write("Введите координаты точки A (x): ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки A (y): ");
y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки A (z): ");
z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты точки B (x): ");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B (y): ");
y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B (z): ");
z2 = Convert.ToDouble(Console.ReadLine());

dif = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine("Расстояние между точками в 3D пространстве {0}", dif);