// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

void PrintArray(int[] array, int index)
{
    if (index >= array.Length)
    {
        return;
    }
    else
    {
        PrintArray(array, index + 1);
        Console.Write(array[index] + " ");
    }
}

PrintArray(numbers,0);