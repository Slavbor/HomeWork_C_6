// Задача 43: Напишите программу, которая найдёт точку
//  пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//   значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
using static System.Console;
Clear();
Write("Enter equation value b1: ");
double b1 = Double.Parse(ReadLine()!);
Write("Enter equation value k1: ");
double k1 = Double.Parse(ReadLine()!);
Write("Enter equation value b2: ");
double b2 = Double.Parse(ReadLine()!);
Write("Enter equation value k2: ");
double k2 = Double.Parse(ReadLine()!);

double x = (b1 - b2) / (k2 - k1);
double y = k2 * x + b2;


WriteLine($"({x}; {y})");



