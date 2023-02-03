    Console.Clear();
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
 var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");

// Console.Clear();
// Console.Write("Введите значения k(1): ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите значения b(1): ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите значения k(2): ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите значения b(2): ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;

// Console.WriteLine($"Результат: ({x}, {y})");