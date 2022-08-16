Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum (int number)
{
    int count = 1;
    int sum = 1;
    while (count <= number)
    {
        sum *=count;
        count++;
    }

    return sum;
}
Console.WriteLine($"Произведение  чисел от 1 до {num} равно {sum(num)}");