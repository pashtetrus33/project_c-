Console.Clear();
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrayRandom = new int[size];
for (int i=0; i < arrayRandom.Length; i++)
{
arrayRandom[i] = new Random().Next(-9,10);
Console.Write($"{arrayRandom[i]} ");
}

for (int i=0; i < arrayRandom.Length; i++)
    arrayRandom[i] = - arrayRandom[i];

Console.WriteLine();

for (int i=0; i < arrayRandom.Length; i++)
Console.Write($"{arrayRandom[i]} ");
Console.WriteLine();

