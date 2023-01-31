int n = Convert.ToInt32(Console.ReadLine());
int countDel = 0, i, j, k, m;
for (i = 2; i <= n / 2; i++)
{
  countDel = 0;
  for (j = 2; j <= i / 2; j++)
  {
    if (i % j == 0)
        countDel++;
  }
  if (countDel == 0)
  {
    m = n - i; // 992 - 73 = 919
    for (k = 2; k <= (m + 1) / 2; k++)
    {
      if (m % k == 0)
        countDel++;
    }
    if (countDel == 0)
    {
      Console.WriteLine($"{i} {m}");
      return;
    }
  }
}