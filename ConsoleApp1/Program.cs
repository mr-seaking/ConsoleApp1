// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.Linq;

Console.Write("Введите свое имя: ");
var first_name = Console.ReadLine();

Console.Write("Введите свою фамилию: ");
var last_name = Console.ReadLine();

Console.Write("Введите свое отчество: ");
var patronym = Console.ReadLine();

Console.WriteLine($"Привет, {last_name} {first_name} {patronym}");


Console.Write("Введите первое число: ");
var a = Console.ReadLine();

Console.Write("Введите второе число: ");
var b = Console.ReadLine();

Console.Write("Введите арифметическую операцию: ");
var c = Console.ReadLine();

if (c == "+")
    {
    double d = Convert.ToDouble(a) + Convert.ToDouble(b);
    Console.WriteLine($"результат: {d}");
    }
if (c == "-")
{
    double d = Convert.ToDouble(a) - Convert.ToDouble(b);
    Console.WriteLine($"результат: {d}");
}
if (c == "*")
{
    double d = Convert.ToDouble(a) * Convert.ToDouble(b);
    Console.WriteLine($"результат: {d}");
}
if (c == "/")
{
    double d = Convert.ToDouble(a) / Convert.ToDouble(b);
    Console.WriteLine($"результат: {d}");
}