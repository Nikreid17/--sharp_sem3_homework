// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве
Console.Clear();
Console.Clear();
Console.Write("Введите X первой точки: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите Y первой точки: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите Z первой точки: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Введите X второй точки: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите Y второй точки: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите Z второй точки: ");
double z2 = double.Parse(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.Write($"Между точкой А({x1};{y1};{z1}) и точкой B({x2};{y2};{z2}) расстояние равно {distance:f3}"); 
