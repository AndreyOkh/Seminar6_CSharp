// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int number = ReadLine("Введите число: ");
PrintBinaryView(number);

void PrintBinaryView(int num)
{
    if(num <= 0) return;
    PrintBinaryView(num / 2);
    Console.Write(num%2);
}
// int sizeArray = (int)Math.Log2(number) + 1;
// int[] array = new int[sizeArray];
// ConvertNumber(array, number, sizeArray - 1);
// //ReverseArray(array);
// Console.WriteLine(string.Join(" ", array));

// void ConvertNumber(int[] array, int number, int i)
// {
//     if (number != 0)
//     {
//         while(i >= 0)
//         {
//             array[i] = number % 2;
//             number /= 2;
//             i--;
//             ConvertNumber(array, number, i);
//         }
//     }
// }

int ReadLine(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine()!);
}