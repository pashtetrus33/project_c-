/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/

Console.Clear();
Console.WriteLine("Программа принимает на вход число и выдаёт сумму цифр в числе.");
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
