/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.Clear();
Console.WriteLine("Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. ");
bool repeat = true;

while (repeat)
{
Console.Write("Введите трехзначное число:  ");
int number = Convert.ToInt32(Console.ReadLine());
if((number < 100) || (number > 999))
{
Console.WriteLine("Вы ввели не трехзначное число!");
continue;
}

int secondDigit = (number - (number / 100)*100 - number % 10) / 10;

Console.WriteLine($"Вторая цифра числа {number} равна {secondDigit}");
Console.WriteLine();
Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'E' затем 'ENTER'");
string? decision = Console.ReadLine();

if (decision?.ToLower() == "e")
{
    repeat = false;
}
}

