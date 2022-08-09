Console.Clear();

Console.Write("Введите число  ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num % 7 == 0) && (num % 23 == 0))
{
Console.WriteLine($"Число {num} кратно одновременно и 7 и 23");
}

else
{
Console.WriteLine($"Число {num} не кратно одновременно и 7 и 23");
}
