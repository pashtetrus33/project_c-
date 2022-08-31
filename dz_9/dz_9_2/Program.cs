/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


// Метод возвращает массив с позициями строк с наименьшей суммой элементов двумерного массива 
int[] printMinSumRaw(int[,] arr)
{
    // Массив индексов строк с минимальной суммой
    int[] arrayRawIndex = new int[arr.GetLength(0)];

    //Массив для сумм элементов по строкам
    int[] sum = new int[arr.GetLength(0)];

    // Заполнение массива суммами элементов строк
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            sum[i] += arr[i, j];
    }
    Console.WriteLine($"Суммы элементов строк: {String.Join(" ", sum)}");
    Console.WriteLine($"Число элементов массива сумм: {sum.Length}");

    if (arr.GetLength(0) == 1)
    {
        Console.WriteLine($"Ответ: В массиве всего одна строка с суммой {sum[0]}");
        return arrayRawIndex;
    }

    // поиск индекса элемента массива сумм с минимальным значением
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[arrayRawIndex[0]] > sum[i])
            arrayRawIndex[0] = i;
    }

    // проверка, что все минимальные суммы массива одинаковые
    int equalSumCount = 0;
    int k = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[arrayRawIndex[0]] == sum[i])
        {
            equalSumCount++;
            arrayRawIndex[k++] = i;
        }
    }
    if ((equalSumCount < sum.Length) && (equalSumCount > 1))
    {
        Console.Write($"Ответ: несколько строк с одинаковой минимальной суммой. Cтроки с номерами: ");
        for (int i = 0; i < sum.Length; i++)
        {
            if (sum[arrayRawIndex[0]] == sum[arrayRawIndex[i]])
            Console.Write($"{arrayRawIndex[i]+1}  ");

        }
        Console.WriteLine();

        return arrayRawIndex;
    }

    if (equalSumCount == sum.Length)
    {
        Console.WriteLine($"Ответ: суммы строк одинаковые и равны {sum[0]}");
        arrayRawIndex[0] = -1;
        return arrayRawIndex;
    }

    Console.WriteLine($"Ответ: наименьшая сумма элементов в строке {arrayRawIndex[0] + 1}.");
    return arrayRawIndex;
}

//Метод заполнения двумерного массива размера (maxRaw, maxCol),
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
void array2DPrint(int[,] arr, string message)
{
    Console.WriteLine();
    Console.WriteLine($"Двумерный массив {message}:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]}".PadLeft(4));
        Console.WriteLine();
    }
    Console.WriteLine();
}

//флаг для выхода из основного цикла программы
bool repeat = true;

// основной цикл программы
while (repeat)
{
    Console.Clear();
    Console.WriteLine("Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов.");
    Console.WriteLine("Введите размер двумерного массива:");
    int rowNum = 0;
    //проверка на ввод целого числа больше нуля
    while (rowNum <= 0)
    {
        Console.Write("Введите количество строк (> 0): ");
        //проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out rowNum))
            Console.Write("Ошибка ввода! Введите целое число больше нуля!: ");
    }
    int colNum = 0;
    //проверка на ввод целого числа больше нуля
    while (colNum <= 0)
    {
        Console.Write("Введите количество столбцов (> 0): ");
        //проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out colNum))
            Console.Write("Ошибка ввода! Введите целое число больше нуля!: ");
    }
    int minNumber = 1;
    int maxNumber = 0;
    while (minNumber > maxNumber)
    {
        Console.WriteLine("Введите диапазон значений элементов двумерного массива:");
        Console.Write("Введите минимальное значение элементов массива (min <= max): ");
        //проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out minNumber))
            Console.Write("Ошибка ввода! Введите целое число!: ");

        Console.Write("Введите максимальное значение элементов массива (max >= min): ");
        //проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out maxNumber))
            Console.Write("Ошибка ввода! Введите целое число!: ");
    }

    int[,] array = arrayFill(rowNum, colNum, minNumber, maxNumber);
    array2DPrint(array, "");
    printMinSumRaw(array);

    Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
    string? decision = Console.ReadLine();
    if ((decision?.ToLower() == "q") || (decision?.ToLower() == "й"))
        repeat = false;
}
