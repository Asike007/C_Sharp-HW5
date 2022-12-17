// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = CreateArray(6, -99, 100);
Console.Write("[ ");
PrintArray(array);
Console.Write("] -> ");
Console.Write(" ");
Console.Write(SumArr(array));


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

int SumArr(int[] inArray)
{
    int result = 0;
    for (int index = 1; index < inArray.Length; index = index + 2)
    {
        result = result + inArray[index];
    }
    return result;
}

