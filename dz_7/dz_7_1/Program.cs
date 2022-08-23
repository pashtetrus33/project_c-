/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

//Метод заполнения двумерного массива размером, m×n, заполненный случайными вещественными числами.
double[,] arrayFill(int row, int col, double min, double max)
{
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
                if (array[i,j] > max)
                array[i,j] = max;
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
}

bool repeat = true;
while (repeat)
{
    Console.Clear();
    Console.WriteLine("Программа задает двумерный массив размером m×n, заполненный случайными вещественными числами..");
    Console.WriteLine("Введите размер двумерного массива:");
    Console.Write("Введите количество строк (m): ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов (n): ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите минимальное значение элементов массива: ");
    double minNumber = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите максимальное значение элементов массива: ");
    double maxNumber = Convert.ToDouble(Console.ReadLine());



    double[,] array = arrayFill(m, n, minNumber, maxNumber);
    arrayPrint(array);

    Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
    string? decision = Console.ReadLine();
    if ((decision?.ToLower() == "q") || (decision?.ToLower() == "й"))
        repeat = false;
}