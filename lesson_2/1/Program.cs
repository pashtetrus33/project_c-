Console.Clear();
Console.Write("Введите число1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max)
{
    max = num2;
}

if (num3 > max)
{
    max = num3;
}

Console.WriteLine($"Число1 = {num1}, Число2 = {num2}, Число3 = {num3}");
Console.WriteLine($"Наибольше из этих чисел = {max}");

if (num1%2 == 0)
{
    Console.WriteLine($"Число1 = {num1} - четное!");
}

else
{
    Console.WriteLine($"Число1 = {num1} - нечетное!");
}

if (num2 % 2 == 0)
{
    Console.WriteLine($"Число1 = {num2} - четное!");
}
else
{
    Console.WriteLine($"Число1 = {num2} - нечетное!");
}

if (num3 % 2 == 0)
{
    Console.WriteLine($"Число1 = {num3} - четное!");
}

else
{
    Console.WriteLine($"Число1 = {num3} - нечетное!");
}

int count = 1;
while (count <= num1)
{
    if (count % 2 == 0)
    {
        Console.Write(count + " ");
    }
    count++;
}
Console.WriteLine();
