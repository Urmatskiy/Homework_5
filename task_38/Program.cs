// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateMassive(int lenght, int first, int last)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = new Random().Next(first, last + 1);
    }
    return arr;
}

int DiffMaxMin(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return (max - min);
}

int[] array = CreateMassive(5, 1, 10);
int result = DiffMaxMin(array);

Console.WriteLine($"[{string.Join(", ", array)}] -> {result}");