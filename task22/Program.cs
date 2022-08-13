// принимает на вход число N и выдает таблицу квадратов чисел от 1 до N. Если 5 -> 1, 4, 9, 16, 25
Console.Clear();
Console.WriteLine("введите число ");
double N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);                               // число N будет положительным
double count = 1;
if (N != 0)                                    // число не равно 0
        while (count <= N)
{
        Console.WriteLine(Math.Pow(count, 2));
        count++;
}
else
{
    Console.WriteLine(0);
}