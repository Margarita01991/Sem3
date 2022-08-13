// принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
Console.WriteLine("введите координаты точки A: введите xa");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите ya");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите координаты точки B: введите xb");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите yb");
double yb = Convert.ToDouble(Console.ReadLine());
double[] arrayA = {xa, ya};
double[] arrayB = {xb, yb};

double distance = Math.Sqrt(Math.Pow(arrayA - arrayA, 2));

Console.WriteLine($"Расстояние между точками равно {distance}");