// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateMassive(int lenght, int first, int last)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = new Random().Next(first, last + 1);
    }
    return arr;
}

int SumOfOddIndex(int[] arr)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        count += arr[i];
    }
    return count;
}

int[] array = CreateMassive(10, 1, 10);
int result = SumOfOddIndex(array);

Console.WriteLine($"[{string.Join(", ", array)}] -> {result}");
