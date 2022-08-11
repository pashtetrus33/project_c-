/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Программа принимает на вход число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
bool repeat = true;

while (repeat)
{
Console.Write("Введите число (не выходящее за границы int):  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


if(number%2 == 0)
{
    Console.WriteLine($"Число {number} является четным.");
}
else
{
    Console.WriteLine($"Число {number} является нечетным.");
}

Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'E' затем 'ENTER'");
string? decision = Console.ReadLine();

if (decision?.ToLower() == "e")
{
    repeat = false;
}
}


