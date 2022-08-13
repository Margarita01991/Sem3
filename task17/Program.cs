// программа которая принимает на вход координаты точки (x и y), они не равны 0 и выдает номер четверти плоскости в которой эта точка
// x>0,y>0 - 1 quart, x<0,y>0 - 2 quart, x<0,y<0 - 3 quart, x>0,y<0 - 4 quart
Console.Clear();
int[] point = new int[2]; // создаем массив на 2 значения (x,y)

//Console.WriteLine("введите координату x ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("введите координату y ");
//int y = Convert.ToInt32(Console.ReadLine());
//Console.SetCursorPosition(y, x);
//Console.WriteLine("+");
Console.WriteLine("введите координату x ");
point[0] = Convert.ToInt32(Console.ReadLine());// в наш массив мы записали первую координату
Console.WriteLine("введите координату y ");
point[1] = Convert.ToInt32(Console.ReadLine());

if(point[0] > 0 && point[1] > 0)
{
    Console.WriteLine("point in 1 quart");
}
else if(point[0] < 0 && point[1] > 0)
{
    Console.WriteLine("point in 2 quart");
}
else if(point[0] < 0 && point[1] < 0)
{
    Console.WriteLine("point in 3 quart");
}
else if(point[0] > 0 && point[1] < 0)
{
    Console.WriteLine("point in 4 quart");
}
else 
{
     Console.WriteLine("точка лежит на оси");   
}