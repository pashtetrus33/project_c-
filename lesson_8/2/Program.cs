

/Метод заполнения двумерного массива размера (maxRaw, maxCol),
// элементы массива - случайные целые числа в заданном диапазоне (min, max).
int[,] arrayFill(int maxRow, int maxCol, int min, int max)
{
    int[,] array = new int[maxRow, maxCol];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max + 1);
    }
    return array;
}

//Метод печати целочисленного двумерного массива в консоль
void arrayPrint(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]}".PadLeft(3));
        Console.WriteLine();
    }
    Console.WriteLine();
}
