/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

// Метод подсчета среднего арифметического по столбцам двумерного массива
double[] countColumnAverage(int[,] arr)
{
    double[] resultArray = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
            resultArray[j] += arr[i, j] / (double)arr.GetLength(0);
    }
    return resultArray;
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

//Метод печати одномерного массива с вещественными числами в консоль
void arrayPrintDouble(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = Math.Round(arr[i], 1);
    Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join(" ; ", arr)} ");
    Console.WriteLine();
}

//флаг для выхода из основного цикла программы
bool repeat = true;

// основной цикл программы
while (repeat)
{
    Console.Clear();
    Console.WriteLine("Программа выводит в консоль среднее арифметическое элементов в каждом столбце двумерного целочисленного массива.");
    Console.WriteLine("Введите значения размера двумерного массива:");
    int m = 0;
    //проверка на ввод целого числа больше нуля
    while (m <= 0)
    {
        Console.Write("Введите количество строк (m > 0): ");
        //проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out m))
            Console.Write("Ошибка ввода! Введите целое число больше нуля!: ");
    }
    int n = 0;
    //проверка на ввод целого числа больше нуля
    while (n <= 0)
    {
        Console.Write("Введите количество столбцов (n > 0): ");
        //проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out n))
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

    int[,] array = arrayFill(m, n, minNumber, maxNumber);
    arrayPrint(array);
    double[] result = countColumnAverage(array);
    arrayPrintDouble(result);

    Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
    string? decision = Console.ReadLine();
    if ((decision?.ToLower() == "q") || (decision?.ToLower() == "й"))
        repeat = false;
}
