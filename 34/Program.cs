Console.Clear();
int size = ReadInt("Введите размер массива: ");
int [] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;
for (int i = 0; i < numbers.Length; i++)
    {if (numbers[i] % 2 == 0){result++;}}

    if (result % 10 == 1)
    {Console.WriteLine($"В массиве {result} четное число");}
    
    if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
    {Console.WriteLine($"В массиве {result} четных числа");}
else
    Console.WriteLine($"В массиве {result} четных чисел");
void FillArrayRandomNumbers(int [] array)
    {for (int i = 0; i < array.Length; i++)
    {array[i] = new Random().Next(99, 999);}
    }
void PrintArray(int[] array)
    {for (int i = 0; i < array.Length; i++)
    {Console.Write(array[i] + " ");}
    Console.WriteLine();
    }
int ReadInt(string message)
    {Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
    }

// void InputArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(100, 1000); // [100, 999]
// }


// int CountEvenInArray(int[] array)
// {
//     int count = 0;
//     foreach(int element in array)
//     {
//       if (element % 2 == 0)
//         count++; // count = count + 1;
//     }
//     return count;
// }
// Console.Clear();
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Результат: {CountEvenInArray(array)}");