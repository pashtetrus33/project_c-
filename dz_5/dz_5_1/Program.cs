/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

Console.Clear();
Console.WriteLine("Программа, которая покажет количество чётных чисел в массиве из положительных трехзначных чисел.");
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
//Метод создания массива с указанным размером (size), заполненого случайными трехзначными числами.
int[] createRandomArray(int size)
{
    int[] arr = new int[size];
    for (int i=0; i < size; i++)
    arr[i] = new Random().Next(100,1000);
    return arr;
}

//Метод вывода массива в консоль
void printArray(int[] arr)
{
    for (int i=0; i < arr.Length; i++)
    Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

//Метод подсчета количества четных чисел в массиве
int countEvenNumbers(int[] array)
{
    int count = 0;
    for (int i=0; i < array.Length; i++)
    {
    if (array[i] % 2 == 0)
    count++;  
    }
return count;
}

int[] randomArray = createRandomArray(arraySize);
printArray(randomArray);
int answer = countEvenNumbers(randomArray);
Console.WriteLine($"Число четных чисел в массиве равно {answer}");

Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
string? decision = Console.ReadLine();
if ((decision?.ToLower() == "q") || (decision?.ToLower() == "й"))
    repeat = false;
}