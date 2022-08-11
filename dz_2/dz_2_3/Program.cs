/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Clear();
Console.WriteLine("Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
bool repeat = true;

while (repeat)
{
Console.Write("Введите цифру, обозначающую день недели (1-7):  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if ((number < 1) || (number > 7))
{
   Console.WriteLine("Вы ввели некорректную цифру! Попробуйте еще раз.");
   continue;
}
if ((number != 6) && (number != 7))
{
     Console.WriteLine($"Цифра {number} не соответствует выходному дню."); 
}
else
{
   Console.WriteLine($"Цифра {number} соответствует выходному дню."); 
}
Console.WriteLine();
Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'E' затем 'ENTER'");
string? decision = Console.ReadLine();

if (decision?.ToLower() == "e")
{
    repeat = false;
}
}
