Console.Clear();
Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int sum = 0;
for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];
    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {numbers[i] = new Random().Next(1,10);}}
void PrintArray(int[] numbers)
    {Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {Console.Write(numbers[i] + " ");}
    Console.Write("]");
    Console.WriteLine();
    }


//     void InputArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 101); // [1, 100]
// }


// int SummaOddInArray(int[] array)
// {
//     int summa = 0;
//     for (int i = 1; i < array.Length; i+=2)
//       summa = summa + array[i];
//     return summa;
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Результат: {SummaOddInArray(array)}");