/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Clear();
Console.WriteLine("Программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
bool repeat = true;

while (repeat)
{
int count = 1;
int answer = 1;
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberB <= 0)
{
Console.WriteLine("Вы ввели не натуральное число B! ");
continue;
}
while (count <= numberB)
{
    answer *= numberA;  
    count++;
}
Console.WriteLine($"Число {numberA} в степени {numberB} равно {answer}");
Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
string? decision = Console.ReadLine();

if (decision?.ToLower() == "q")
    repeat = false;
}