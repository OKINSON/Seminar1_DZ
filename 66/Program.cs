Console.Clear();

Console.WriteLine("Введите начальное число M:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int N = int.Parse(Console.ReadLine());

void NtoMSum (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (M++);
    NtoMSum(M, N, sum);
}

NtoMSum(M, N, 0);