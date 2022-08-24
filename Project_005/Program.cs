// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] array = { 1, 2, 3, 4, 5, 6, 7 };
int[] newArray = new int[array.Length];

for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = array[i];
}

Console.WriteLine($"Исходный массив {string.Join(" ", array)}");
Console.WriteLine($"Исходный массив {string.Join(" ", newArray)}");