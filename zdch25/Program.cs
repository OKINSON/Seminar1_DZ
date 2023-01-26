//  задача 25

Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

    for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine("Результат : " + step);
