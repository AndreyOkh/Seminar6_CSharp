// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Введите числа разделяя их пробелами: ");
string[] numbers = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int countPositive = 0;
foreach (string item in numbers)
{
    if(Convert.ToInt32(item) > 0) countPositive++;
}

Console.WriteLine($"В массиве {string.Join(",", numbers)} положительных чисел {countPositive}.");