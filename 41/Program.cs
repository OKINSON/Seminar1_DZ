Console.Clear();
Console.Write("Введите элементы (через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = arr.Count(x => x > 0);
Console.WriteLine($"Колличество элементов больше 0: {count}");