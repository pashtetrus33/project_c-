Console.Clear();
Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число C: ");
int numC = Convert.ToInt32(Console.ReadLine());

int sum (int number)
{
    int count = 0;
    int sum = 0;
    while (count <= number)
    {
        sum +=count;
        count++;
    }

    return sum;
}
Console.WriteLine($"Cумма чисел от 1 до {numA} равно {sum(numA)}");
Console.WriteLine($"Cумма чисел от 1 до {numB} равно {sum(numB)}");
Console.WriteLine($"Cумма чисел от 1 до {numC} равно {sum(numC)}");
