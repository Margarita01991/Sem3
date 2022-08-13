// принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
Console.Clear();
Console.WriteLine("введите координаты точки A: введите xa");
double xa = Convert.ToDouble(Console.ReadLine());        // double - тип переменной для записи значений с запятой
Console.WriteLine("введите ya");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите координаты точки B: введите xb");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите yb");
double yb = Convert.ToDouble(Console.ReadLine());
//            d = √             (хa – хb) 2      +     (уa – уb) 2) возвести в степень 2
double distance = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));

Console.WriteLine($"Расстояние между точками равно {distance}");