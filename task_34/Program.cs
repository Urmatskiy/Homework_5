// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateMassive(int lenght, int first, int last)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = new Random().Next(first, last + 1);
    }
    return arr;
}

int NumberOfEvenDigits(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) counter++; 
    }
    return counter;
}

int[] array = CreateMassive(10, 1, 10);
int result = NumberOfEvenDigits(array);

Console.WriteLine($"[{string.Join(", ", array)}] -> {result}");