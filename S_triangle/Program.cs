﻿
    Console.Clear();
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double x3 = Convert.ToDouble(Console.ReadLine());
double y3 = Convert.ToDouble(Console.ReadLine());

double A = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double B = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
double C = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));

double p = (A + B + C) / 2;
double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

Console.WriteLine(S);