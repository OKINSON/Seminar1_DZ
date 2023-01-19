Console.Clear();
Console.Write("Введите номер дня недели ");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day >= 1 && Day <=7) {
	if (Day >= 6) {
		Console.Write("выходной");
	} else {
		Console.Write("рабочий");
	}
} else {
	Console.Write("Hееее, это за пределами нашей недели");
}