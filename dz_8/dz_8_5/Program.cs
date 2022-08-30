/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


Console.Clear();
Console.WriteLine("Программа заполнит спирально массив 4 на 4. Решение в лоб )");
//Метод печати целочисленного двумерного массива в консоль
void arrayPrint(int[,] arr)
{
    Console.WriteLine($"Маcсив:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]}".PadLeft(2, '0') + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] numPositions = new int[] { 21, 22, 12, 11, 10, 20, 30, 31, 32, 33, 23, 13, 03, 02, 01, 00 };
int[,] resultArray = new int[4, 4];
int j = 16;
for (int i = 0; i < numPositions.Length; i++)
{
    int x = numPositions[i] / 10;
    int y = numPositions[i] % 10;

    resultArray[x, y] = j--;
}

arrayPrint(resultArray);
