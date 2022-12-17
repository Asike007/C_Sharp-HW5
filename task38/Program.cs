// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

int[] array = CreateArray(10, 0, 99);
Console.Write("[ ");
PrintArray(array);
Console.Write("] -> ");
Console.Write(" ");
Diff(array);

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void Diff(int[] inArray)
{
    int max = inArray[0];
    int min = inArray[0];
    int result = 0;
    for (int index = 1; index < inArray.Length; index++)
    {
        if (max < inArray[index]) max = inArray[index];
        if (min > inArray[index]) min = inArray[index];
        result = max - min;
    }
    Console.Write($"max = {max}, ");
    Console.Write($"min = {min}, ");
    Console.Write($"Разницу между максимальным и минимальным элементами массива = {result} ");
}
