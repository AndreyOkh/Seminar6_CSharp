// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int n = ReadLine("Введите число: ");
int[] f = new int[n];
f[1] = 1;

for (int i = 2; i < n; i++)
{
    f[i] = f[i - 1] + f[i - 2];
}

Console.WriteLine(string.Join(" ", f));

int ReadLine(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine()!);
}