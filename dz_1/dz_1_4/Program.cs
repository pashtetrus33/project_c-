/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8"); */

Console.WriteLine("Программа принимает на вход число (N), а на выходе показывает все чётные числа от 1 до N.");
bool repeat = true;

while (repeat)
{
Console.Write("Введите число (не выходящее за границы int):  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int count = 1;
while(count <= number)
{
    if(count % 2 == 0)
    {
        Console.Write(count + " ");
    }
    count++;
}

Console.WriteLine();
Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'E' затем 'ENTER'");
string? decision = Console.ReadLine();

if (decision?.ToLower() == "e")
{
    repeat = false;
}
}
