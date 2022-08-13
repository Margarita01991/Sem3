Console.Clear();
Console.WriteLine("введите номер четверти ");
int quart = Convert.ToInt32(Console.ReadLine());
string[] array = {"x > 0; y > o", "x < 0; y > ", "x < 0; y < o", "x > 0; y < o"};// записали в стринговый массив все возможные значения 
if(quart >=1 && quart <= 4)                                                      // проверили, поставили ограничения на ввод от 1 до 4
{
    Console.WriteLine(array[quart-1]);                                           // -1, так как в массиве начало с 0
}
else
{
    Console.WriteLine("такой четверти нет");
}
