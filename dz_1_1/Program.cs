/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

 a = 5; b = 7 -> max = 7
 a = 2 b = 10 -> max = 10
 a = -9 b = -3 -> max = -3 */

Console.WriteLine("Программа принимает на вход два числа и выдаёт, какое число большее, а какое меньшее.");
bool repeat = true;

while (repeat)
{
Console.Write("Введите число 1:  ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2:  ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if(number1 < number2)
{
    Console.WriteLine($"Число {number2} больше чем число {number1}");
}
else if ( number1 == number2)
{
    Console.WriteLine($"Число {number1} равно числу {number2}");
}

else
{
    Console.WriteLine($"Число {number1} больше чем число {number2}");
}

Console.WriteLine();

Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'E' затем 'ENTER'");
string? decision = Console.ReadLine();

if (decision.ToLower() == "e")
{
    repeat = false;
}
}
