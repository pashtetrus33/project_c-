Console.Clear();

// Метод заполнения двумерного массива неповторяющимися целыми числами.Аргументы - число строк, число столбцов, минимальное (начальное) число массива
int[,] GetUniqueSeqWithMix(int row, int col, int startValue)
{
    int[,] set = new int[row, col];
    int size = row * col;

    // Заполняем по порядку начиная с startValue
    for (int i = 0; i < set.GetLength(0); i++)
    {
        for (int j = 0; j < set.GetLength(1); j++)
            set[i, j] = startValue + i * set.GetLength(1) + j;
    }

    // Перемешиваем числа
    for (int i = 0; i < set.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < set.GetLength(1) - 1; j++)
        {
            int posRow = Random.Shared.Next(i + 1, row);
            int posCol = Random.Shared.Next(j + 1, col);
            (set[i, j], set[posRow, posCol]) = (set[posRow, posCol], set[i, j]);
        }
    }
    return set;
}

/* //Метод заполнения двумерного массива размера (maxRaw, maxCol),
// элементы массива - случайные целые числа в заданном диапазоне (min, max).
int[,] fill2DIntArray(int maxRow, int maxCol, int min, int max)
{
    int[,] array = new int[maxRow, maxCol];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max + 1);
    }
    return array;
} */

//Метод печати целочисленного двумерного массива в консоль
void print2DIntArray(int[,] arr, string msg)
{
    Console.WriteLine($"Двумерный массив {msg}:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]}".PadLeft(5));
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Метод поиска координат наименьшего элемента массива
int[] FindMinIn2DIntArray(int[,] arr)
{
    int[] result = new int[2];
    int min = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (min > arr[i, j])
            {
                min = arr[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    Console.WriteLine($"Минимальный элемент в массиве равен {min}. Его позиция: строка {result[0] + 1} столбец {result[1] + 1}");
    return result;
}

//Метод удаления строки и столбца по координатам
int[,] DeleteRawCol(int[,] arr, int[] min)
{
    int[,] result = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if ((i < min[0]) && (j >= min[1]))
                result[i, j] = arr[i, j + 1];
            else if ((i >= min[0]) && (j < min[1]))
                result[i, j] = arr[i + 1, j];
            else if ((i >= min[0]) && (j >= min[1]))
                result[i, j] = arr[i + 1, j + 1];
            else
                result[i, j] = arr[i, j];
        }
    }
    Console.WriteLine($"Удаляем строку {min[0] + 1} и столбцец {min[1] + 1}.");
    return result;
}

int row = 0;
int col = 0;
int startValue;
while (row <= 0)
{
    Console.Write("Введите число строк в массиве (>0): ");
    //проверка на ввод целого числа
    while (!int.TryParse(Console.ReadLine(), out row))
        Console.Write("Ошибка ввода! Введите целое число!: ");
}

while (col <= 0)
{

    Console.Write("Введите число столбцов в массиве (>0): ");
    //проверка на ввод целого числа
    while (!int.TryParse(Console.ReadLine(), out col))
        Console.Write("Ошибка ввода! Введите целое число!: ");
}

Console.Write("Введите начальное (минимальное) число массива: ");
//проверка на ввод целого числа
while (!int.TryParse(Console.ReadLine(), out startValue))
    Console.Write("Ошибка ввода! Введите целое число!: ");

int[,] arrayBefore = GetUniqueSeqWithMix(row, col, startValue);
print2DIntArray(arrayBefore, "до");

int[] min = FindMinIn2DIntArray(arrayBefore);

int[,] arrayAfter = DeleteRawCol(arrayBefore, min);

print2DIntArray(arrayAfter, "после");


