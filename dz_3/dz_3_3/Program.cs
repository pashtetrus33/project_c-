/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Clear();
Console.WriteLine("Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
bool repeat = true;

while (repeat)
{
int count=1;
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (count < number)
{
    Console.Write($"{Math.Pow(count,3)}, ");
    count++;
}
Console.WriteLine($"{Math.Pow(count,3)}");
Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
string? decision = Console.ReadLine();

if (decision?.ToLower() == "q")
    repeat = false;
}