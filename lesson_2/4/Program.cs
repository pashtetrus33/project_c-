Console.Clear();

Console.Write("Введите число 1  ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2  ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
Console.WriteLine($"Число {num1} кратно числу {num2}");
}

else
{
Console.WriteLine($"Остаток от деления числа {num1} на число {num2} равен {num1 % num2}");
}
