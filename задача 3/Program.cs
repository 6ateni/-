// Задача 3: Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

int[] FillArray(int size, int minRange, int maxRange)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minRange, maxRange + 1);
    }
    return arr;
}
Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(N, 0, 100);
// Размер массива: N, элементы: [0,100]
Console.WriteLine($"{string.Join(" ", array)}");

int size = array.Length;

void ShowArrayReverse(int[] array, int size)
{
    int j = size - 1;
    if (j == 0)
    {
        Console.WriteLine(array[j]);
        return;
    }

    Console.Write(array[j] + " ");
    ShowArrayReverse(array, size - 1);
}
ShowArrayReverse(array, size);