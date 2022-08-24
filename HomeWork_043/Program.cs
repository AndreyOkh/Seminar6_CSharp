// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = ReadLine("Введите число b1: ");
double k1 = ReadLine("Введите число k1: ");
double b2 = ReadLine("Введите число b2: ");
double k2 = ReadLine("Введите число k2: ");

if (k1 == k2) Console.WriteLine("Прямые параллельны.");
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"{x} {y}");
}

double ReadLine(string msg)
{
    Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine()!);
}