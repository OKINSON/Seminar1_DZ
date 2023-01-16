Console.Clear();
Console.WriteLine("Введите превое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n > m)
Console.WriteLine(n);
else if (n < m)
Console.WriteLine(m);
else
 Console.WriteLine("=");