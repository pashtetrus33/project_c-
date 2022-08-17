/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

Console.Clear();
Console.WriteLine("Программа находит разницу между максимальным и минимальным элементов массива с вещественными числами.");
bool repeat = true;

while (repeat)
{
int answer = 0;
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number;
if (temp < 0)
temp = - temp;
while (temp > 0)
{
    answer += temp % 10;
    temp /= 10;
}

Console.WriteLine($"Cумма цифр числа {number} равна {answer}");
Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
string? decision = Console.ReadLine();

if (decision?.ToLower() == "q")
    repeat = false;
}
