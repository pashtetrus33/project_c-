Console.Clear();

Console.Write("Введите число 1  ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2  ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1*num1 == num2)
{
Console.WriteLine($"Число {num2} является квадратом числа {num1}");
}

else
{
Console.WriteLine($"Число {num2} не является квадратом числа {num1}");
}