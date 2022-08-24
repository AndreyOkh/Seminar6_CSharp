// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] arr = FillArrayRandom(5, 1, 9);
Console.WriteLine(string.Join(" ", arr));
ReverseArray(arr);
Console.WriteLine(string.Join(" ", arr));

int[] FillArrayRandom (int size, int startRandom, int endRandom)
{
    int[] array = new int[size];

    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(startRandom, endRandom + 1);
    }
    return array;
}

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}