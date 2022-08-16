Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int digitCount (int number)
{
    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }

    return count;
}
Console.WriteLine($"В числе {num} {digitCount(num)} цифр(ы)");
