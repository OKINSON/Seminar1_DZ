
//     Console.Clear();
// Console.Write("Введите числа (через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = arr.Count(x => x > 0);

// Console.WriteLine($"Колличество элементов больше 0: {count}");


Console.Clear();
Console.Write("Введите колличество элементов: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
        count++; // count = count + 1;
}
Console.WriteLine($"Результат: {count}");