//  задача 27

Console.Clear();
// Console.WriteLine("введите число: ");
// int i = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
//     while (i > 0)
// {
// int num = i % 10;
// i = i / 10;
// sum = sum + num;
// }
// Console.WriteLine("сумма цифр в этом числе: " + sum);

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), result = 0;
while (n > 0)
{
    result = result + n % 10; // result += n %  10;
    n = n / 10; // n /= 10;
}
Console.WriteLine(result);