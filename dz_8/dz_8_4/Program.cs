/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

bool Contains(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
            return true;
    }
    return false;
}

int[] MatrixParameters(int matrixNum)
{
    Console.WriteLine($"Введите размеры трехмерного массива {matrixNum}:");
    int xNumber = 0;
    //проверка на ввод целого числа больше нуля
    while (xNumber <= 0)
    {
        Console.Write("Введите количество строк (x > 0): ");
        //проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out xNumber))
            Console.Write("Ошибка ввода! Введите целое число больше нуля!: ");
    }
    int yNumber = 0;
    //проверка на ввод целого числа больше нуля
    while (yNumber <= 0)
    {
        Console.Write("Введите количество столбцов (y > 0): ");
        //проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out yNumber))
            Console.Write("Ошибка ввода! Введите целое число больше нуля!: ");
    }
    int zNumber = 0;
    //проверка на ввод целого числа больше нуля
    while (zNumber <= 0)
    {
        Console.Write("Введите количество столбцов (z > 0): ");
        //проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out zNumber))
            Console.Write("Ошибка ввода! Введите целое число больше нуля!: ");
    }

    int[] parametrs = { xNumber, yNumber, zNumber };
    return parametrs;
}

//Метод заполнения массива неповторяющимися целыми числами
int[] difNumFillArray(int size, int min, int max)
{
    int[] tempArray = new int[size];
    for (int i = 0; i < tempArray.Length; i++)
    {
        int num = new Random().Next(min, max + 1);
        if (!Contains(tempArray, num))
            tempArray[i] = num;
        else
            i--;
    }
    Console.Write($"Массив из неповторяющихся целых двузначных чисел: {String.Join(" ", tempArray)}");
    return tempArray;
}

//Метод заполнения матрицы размером (x, y, z)
// элементы матрицы - случайные неповторяющиеся целые двузначные числа  в заданном диапазоне (min, max).
int[,,] array3DFill(int sizeX, int sizeY, int sizeZ)
{

    int[,,] array3D = new int[sizeX, sizeY, sizeZ];
    if (sizeX * sizeY * sizeZ > 90)
    {
        Console.WriteLine();
        Console.WriteLine($"Не хватает неповторяющихся двухзначных чисел для заполения данного массива. Массив заполен нулями по умолчанию!");
        return array3D;
    }

    int[] array = difNumFillArray(sizeX * sizeY * sizeZ, 10, 99);
    int index = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = array[index++];
            }
        }
    }
    return array3D;
}

//Метод печати 3D массива построчно в консоль
void array3DPrint(int[,,] arr, string message)
{
    Console.WriteLine();
    Console.WriteLine($"Маcсив {message}:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
                Console.Write($"{arr[j, k, i]}({j} {k} {i}) ".PadLeft(4));
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

//флаг для выхода из основного цикла программы
bool repeat = true;

// основной цикл программы
while (repeat)
{
    Console.Clear();
    Console.WriteLine("Программа формирует трёхмерный массив из неповторяющихся двузначных чисел и построчно выводит массив, добавляя индексы каждого элемента.");
    int[] matrixParam1 = MatrixParameters(1);
    int[,,] integer3DArray = array3DFill(sizeX: matrixParam1[0], sizeY: matrixParam1[1], sizeZ: matrixParam1[2]);
    array3DPrint(integer3DArray, message: "3D");
    Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
    string? decision = Console.ReadLine();
    if ((decision?.ToLower() == "q") || (decision?.ToLower() == "й"))
        repeat = false;
}


