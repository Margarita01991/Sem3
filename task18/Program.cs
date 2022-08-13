// по заданному номеру четверти показывает диапазон возможных значений
// x>0,y>0 - 1 quart, x<0,y>0 - 2 quart, x<0,y<0 - 3 quart, x>0,y<0 - 4 quart
Console.Clear();
Console.WriteLine("введите номер четверти ");

int quart = Convert.ToInt32(Console.ReadLine());//

if(quart == 1)
{
    Console.WriteLine("x>0,y>0");
}
else if(quart == 2)
{
    Console.WriteLine("x<0,y>0");
}
else if(quart == 3)
{
    Console.WriteLine("x<0,y<0");
}
else if(quart == 4)
{
    Console.WriteLine("x>0,y<0");
}
else 
{
     Console.WriteLine("введите номер от 1 до 4");   
}