/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Clear();
Console.WriteLine("Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
bool repeat = true;

while (repeat)
{
Console.Write("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit =0;

if (number < 0)
{
    number = -number;
}
if (number < 100)
{
   Console.WriteLine($"Третьей цифры нет!"); 
}

else if (number < 1000 ) 
{
    thirdDigit = number % 10;
    Console.WriteLine($"Третья цифра равна {thirdDigit}"); 
}

else if (number < 10000 ) 
{
    number = number / 10;
    thirdDigit = number % 10;
    Console.WriteLine($"Третья цифра ранва {thirdDigit}"); 
}

else if (number < 100000 ) 
{
    number = number / 100;
    thirdDigit = number % 10;
    Console.WriteLine($"Третья цифра ранва {thirdDigit}"); 
}

else if (number < 1000000 ) 
{
    number = number / 1000;
    thirdDigit = number % 10;
    Console.WriteLine($"Третья цифра ранва {thirdDigit}"); 
}

else if (number < 10000000 ) 
{
    number = number / 10000;
    thirdDigit = number % 10;
    Console.WriteLine($"Третья цифра ранва {thirdDigit}"); 
}

else if (number < 100000000 ) 
{
    number = number / 100000;
    thirdDigit = number % 10;
    Console.WriteLine($"Третья цифра ранва {thirdDigit}"); 
}

else if (number < 1000000000 ) 
{
    number = number / 1000000;
    thirdDigit = number % 10;
    Console.WriteLine($"Третья цифра ранва {thirdDigit}"); 
}

else
{
   Console.WriteLine("Вы ввели слишком большое число :)");
}
Console.WriteLine();
Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'E' затем 'ENTER'");
string? decision = Console.ReadLine();

if (decision.ToLower() == "e")
{
    repeat = false;
}
}
