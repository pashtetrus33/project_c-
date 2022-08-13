/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.Clear();
Console.WriteLine("Программа задаёт массив из 8 элементов и выводит их на экран.");
bool repeat = true;
int CONST = 8;  // Константа для задания размера массива

// Метод заполнения массива
int[]  arrayFill(int count, int min, int max)
{
int[] temp = new int[count];   
int i = 0;    
while (i < temp.Length)
{
temp[i] = new Random().Next(min, max+1);
i++;
}

return temp;
}

// Метод вывода массива в консль
void arrayPrint(int[] temp)
{   
int i = 0;    
while (i < temp.Length)
{
Console.Write($"[{temp[i]}] ");
i++;
}
}

while (repeat)
{
Console.Write("Введите минимальное значение элемента массива: ");
int minRandom = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int maxRandom = Convert.ToInt32(Console.ReadLine());
if (minRandom > maxRandom)
{
    Console.WriteLine("Неверный ввод: максимальное значение меньше минимального!");
    continue;
}

int [] array = arrayFill(CONST, minRandom, maxRandom);
arrayPrint(array);
Console.WriteLine();
Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
string? decision = Console.ReadLine();

if (decision?.ToLower() == "q")
    {
        repeat = false;
    }
}