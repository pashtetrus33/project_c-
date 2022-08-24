/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

// Метод вывода элемента массива по индексу
void arrayFindElementByIndex(int i, int j, double[,] arr)
{
    if ((i >= 0) && (j >= 0) && (i < arr.GetLength(0)) && (j < arr.GetLength(1)))
    {
        Console.WriteLine();
        Console.WriteLine($"Элемент с индексами [{i}][{j}] есть в массиве, его значение: {Math.Round(arr[i, j], 1)}");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"Элемента с индексами [{i}][{j}] нет в массиве.");
        Console.WriteLine();
    }
}

//Метод заполнения двумерного массива случайного размера (maxRaw, maxCol),
// элементы массива - случайные вещественные числа в заданном диапазоне (min, max).
double[,] arrayFill(int maxRow, int maxCol, double min, double max)
{
    int row = new Random().Next(1, maxRow + 1);
    int col = new Random().Next(1, maxCol + 1);
    double[,] array = new double[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min == max)
                array[i, j] = min;
            else
            {
                array[i, j] = new Random().Next((int)min, (int)max) + min - (int)min + new Random().NextDouble();
                if (array[i, j] > max)
                    array[i, j] = max;
            }
        }
    }
    return array;
}

//Метод печати массива в консоль
void arrayPrint(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{Math.Round(arr[i, j], 1)}".PadLeft(6));
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
    Console.WriteLine("Программа на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
    Console.WriteLine("Введите значения максимального размера двумерного массива:");
    int m = 0;
    //проверка на ввод целого числа больше нуля
    while (m <= 0)
    {
        Console.Write("Введите максимальное количество строк (m > 0): ");
        //проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out m))
            Console.Write("Ошибка ввода! Введите целое число больше нуля!: ");
    }

    int n = 0;
    //проверка на ввод целого числа больше нуля
    while (n <= 0)
    {
    Console.Write("Введите максимальное количество столбцов (n > 0): ");
    //проверка на ввод целого числа
    while (!int.TryParse(Console.ReadLine(), out n))
        Console.Write("Ошибка ввода! Введите целое число больше нуля!: ");
    }

    double minNumber = 1;
    double maxNumber = 0;
    while (minNumber > maxNumber)
    {
        Console.WriteLine("Введите диапазон значений элементов двумерного массива:");
        Console.Write("Введите минимальное значение элементов массива (min <= max): ");
        //проверка на ввод вещественного числа
        while (!double.TryParse(Console.ReadLine(), out minNumber))
        Console.Write("Ошибка ввода! Введите вещественное число!: ");
        
        Console.Write("Введите максимальное значение элементов массива (max >= min): ");
        //проверка на ввод вещественного числа
        while (!double.TryParse(Console.ReadLine(), out maxNumber))
        Console.Write("Ошибка ввода! Введите вещественное число!: ");
    }


    Console.WriteLine("Введите индексы элемента массива array[i,j]: ");
    int indexRaw = -1;
    while (indexRaw < 0)
    {
        Console.Write("Введите i (>= 0): ");
        //проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out indexRaw))
        Console.Write("Ошибка ввода! Введите целое число (i >= 0): ");
    }
    int indexCol = -1;
    while (indexCol < 0)
    {
        Console.Write("Введите j (>= 0): ");
        // проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out indexCol))
        Console.Write("Ошибка ввода! Введите целое число (j >= 0): ");
    }

    double[,] array = arrayFill(m, n, minNumber, maxNumber);
    arrayFindElementByIndex(indexRaw, indexCol, array);
    arrayPrint(array);

    Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
    string? decision = Console.ReadLine();
    if ((decision?.ToLower() == "q") || (decision?.ToLower() == "й"))
        repeat = false;
}
