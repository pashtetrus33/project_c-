/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

Console.Clear();
Console.WriteLine("Программа находит разницу между максимальным и минимальным элементов массива с вещественными числами.");
bool repeat = true;

while (repeat)
{
Console.Write("Введите раземер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

if (arraySize < 1)
{
    Console.WriteLine("Размер массива должен быть больше 0, попробуйте снова!");
    continue;
}

Console.Write("Введите минимальное значение элемента массива: ");
int minRandom = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int maxRandom = Convert.ToInt32(Console.ReadLine());
if (minRandom > maxRandom)
{
    Console.WriteLine("Неверный ввод: максимальное значение меньше минимального!");
    continue;
}
//Метод создания массива с указанным размером (size) и указанными границами (minRandom, maxRandom) , заполненого случайными вещественными числами.
double[] createRandomArray(int size, int minRandom, int maxRandom)
{
    double[] arr = new double[size];
    for (int i=0; i < size; i++)
    arr[i] = (new Random().NextDouble()) + (new Random().Next(minRandom, maxRandom));
    return arr;
}

//Метод печати массива в консоль
void printArray(double[] arr)
{
    for (int i=0; i < arr.Length; i++)
    Console.Write($"{Math.Round(arr[i],3)}  ");
    Console.WriteLine();
}

//Метод возвращает массив с индексами максимального и минимального значения
int[] findMinMax(double[] array)
{
    int max = 0;   // индекс максимального значения в массиве
    int min = 0;   // индекс минимального значения в массиве
    for (int i=1; i < array.Length; i++)
    {
        if (array[i] > array[max])
        max = i;
        else if (array[i] < array[min])
        min = i;
     
    }
    int[] arr = {max, min};
return arr;
}

double[] randomArray = createRandomArray(arraySize, minRandom, maxRandom);
printArray(randomArray);
int max  = findMinMax(randomArray)[0];
int min  = findMinMax(randomArray)[1];

double diff = randomArray[max] - randomArray[min];
Console.WriteLine($"Разница между максимальным {Math.Round(randomArray[max],3)} и минимальным {Math.Round(randomArray[min],3)} элементами массива равна {Math.Round(diff,3)}");

Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
string? decision = Console.ReadLine();
if ((decision?.ToLower() == "q") || (decision?.ToLower() == "й"))
    repeat = false;
}
