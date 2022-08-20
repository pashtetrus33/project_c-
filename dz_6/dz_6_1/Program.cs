/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/

//Метод заполнения целочисленного массива, размер которого задается пользовательским водом из консоли
int[] arrayFill()
{
int arraySize = 0;
while (arraySize < 1)
{
Console.Write("Введите количество чисел для ввода: ");
arraySize = Convert.ToInt32(Console.ReadLine());
if (arraySize < 1)
Console.WriteLine("Количество должно быть больше 0, попробуйте снова!");
}
int[] array = new int[arraySize];
for(int i=0; i<arraySize; i++)
    {
    Console.Write($"Введите чиcло № {i+1} : ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    } 
    return array;
}
//Метод подсчета положительных чисел в массиве
int arrayCountPositive (int[] array)
{
    int count =0;
for(int i=0; i<array.Length; i++)
    {
    if (array[i] > 0)
    count++;  
    }
    return count;
}

//Метод печати массива в консоль
void arrayPrint(int[] arr)
{  
    Console.WriteLine($"Вы ввели массив чисел: {string.Join(" ",arr)}");
}

bool repeat = true;
while (repeat)
{
Console.Clear();
Console.WriteLine("Программа подсчитает, сколько чисел больше 0 ввёл пользователь.");

int[] array = arrayFill();
arrayPrint(array);
int count = arrayCountPositive(array);
Console.WriteLine($"Число положительных чисел равно: {count}.");

Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
string? decision = Console.ReadLine();
if ((decision?.ToLower() == "q") || (decision?.ToLower() == "й"))
    repeat = false;
}