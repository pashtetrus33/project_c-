/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

// Метод возвращает отсортированный двумерный массив. Метод сортировки: убывание элементов каждой строки 
int[,] rowAllignNum(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int maxIndexInRaw = j;
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] > arr[i, maxIndexInRaw])
                    maxIndexInRaw = k;
            }
            int temp = arr[i, j];
            arr[i, j] = arr[i, maxIndexInRaw];
            arr[i, maxIndexInRaw] = temp;
        }
    }
    return arr;
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
    Console.WriteLine("Программа упорядочивает по убыванию элементы каждой строки двумерного массива.");
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
    array2DPrint(array, "до");
    int[,] result = rowAllignNum(array);
    array2DPrint(result, "после");

    Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
    string? decision = Console.ReadLine();
    if ((decision?.ToLower() == "q") || (decision?.ToLower() == "й"))
        repeat = false;
}
