/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

// Расчет произведения двух матриц
int[,] MatrixMultiply(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine($"Произведение двух матриц АВ имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В. {matrix1.GetLength(1)} != {matrix2.GetLength(0)}");
        return resultMatrix;
    }

    for (int raw = 0; raw < resultMatrix.GetLength(0); raw++)
    {
        for (int cal = 0; cal < resultMatrix.GetLength(1); cal++)
        {
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            resultMatrix[raw,cal] += matrix1[raw, i] * matrix2[i, cal];
        }
    }
    return resultMatrix;
}

int[] MatrixParameters(int matrixNum)
{
    Console.WriteLine($"Введите размер матрицы {matrixNum}:");
    int rowNumMatrix = 0;
    //проверка на ввод целого числа больше нуля
    while (rowNumMatrix <= 0)
    {
        Console.Write("Введите количество строк (> 0): ");
        //проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out rowNumMatrix))
            Console.Write("Ошибка ввода! Введите целое число больше нуля!: ");
    }
    int colNumMatrix = 0;
    //проверка на ввод целого числа больше нуля
    while (colNumMatrix <= 0)
    {
        Console.Write("Введите количество столбцов (> 0): ");
        //проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out colNumMatrix))
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
    int[] parametrs = { rowNumMatrix, colNumMatrix, minNumber, maxNumber };
    return parametrs;
}

//Метод заполнения матрицы размером (maxRaw, maxCol),
// элементы матрицы - случайные целые числа в заданном диапазоне (min, max).
int[,] matrixFill(int maxRow, int maxCol, int min, int max)
{
    int[,] array = new int[maxRow, maxCol];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max + 1);
    }
    return array;
}

//Метод печати матрицы в консоль
void matrixPrint(int[,] arr, string message)
{
    Console.WriteLine();
    Console.WriteLine($"Матрица {message}:");
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
    Console.WriteLine("Программа находит произведение двух матриц.");
    int[] matrixParam1 = MatrixParameters(1);
    int[] matrixParam2 = MatrixParameters(2);
    int[,] matrix1 = matrixFill(matrixParam1[0], matrixParam1[1], matrixParam1[2], matrixParam1[3]);
    matrixPrint(matrix1, "1");
    int[,] matrix2 = matrixFill(matrixParam2[0], matrixParam2[1], matrixParam2[2], matrixParam2[3]);
    matrixPrint(matrix2, "2");
    int[,] resultMatrix = MatrixMultiply(matrix1, matrix2);
    matrixPrint(resultMatrix, "произведения");
    Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
    string? decision = Console.ReadLine();
    if ((decision?.ToLower() == "q") || (decision?.ToLower() == "й"))
        repeat = false;
}

