// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2

int[] array = CreateArray(10, 100, 1000);
Console.Write("[ ");
PrintArray(array);
Console.Write("] -> ");
Console.Write(" ");
Console.Write(EvenNumber(array));

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

int EvenNumber(int[] inArray)
{
    int result = 0;
    for (int index = 0; index < inArray.Length; index++)
    {
        if (array[index] % 2 == 0)
        {
            result = result + 1;
        }
    }
    return result;
}
