/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.Clear();
Console.WriteLine("Программа находит сумму элементов, стоящих на нечётных позициях.");
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
//Метод создания массива с указанным размером (size) и указанными границами (minRandom, maxRandom) , заполненого случайными числами.
int[] createRandomArray(int size, int minRandom, int maxRandom)
{
    int[] arr = new int[size];
    for (int i=0; i < size; i++)
    arr[i] = new Random().Next(minRandom,maxRandom + 1);
    return arr;
}

//Метод печати массива в консоль
void printArray(int[] arr)
{
    for (int i=0; i < arr.Length; i++)
    Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

//Метод подсчета суммы элементов стоящих на нечетных позициях в массиве
int sumOddNumbers(int[] array)
{
    int sum = 0;
    for (int i=1; i < array.Length; i+=2)
    {
    sum +=array[i];  
    }
return sum;
}

int[] randomArray = createRandomArray(arraySize, minRandom, maxRandom);
printArray(randomArray);
int answer = sumOddNumbers(randomArray);
Console.WriteLine($"Cумма чисел, стоящих на нечетнх позициях, равна {answer}");

Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
string? decision = Console.ReadLine();
if ((decision?.ToLower() == "q") || (decision?.ToLower() == "й"))
    repeat = false;
}