Console.Clear();
    void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 101); // [1, 100]
}
int SummaOddInArray(int[] array)
{
    int summa = 0;
    for (int i = 1; i < array.Length; i+=2)
      summa = summa + array[i];
    return summa;
}
Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов на нечетных позициях: {SummaOddInArray(array)}");