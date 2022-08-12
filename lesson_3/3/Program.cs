Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

while(count <= number)
{
Console.Write($"{count*count} ");
count++;
}
Console.WriteLine();




