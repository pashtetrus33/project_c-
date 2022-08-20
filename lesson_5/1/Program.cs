Console.Clear();
int[] arrayRandom = new int[12];

for (int i=0; i < arrayRandom.Length; i++)
{
arrayRandom[i] = new Random().Next(-9,10);
Console.Write($"{arrayRandom[i]} ");
}

int sumPositive = 0;
int sumNegative = 0;
for (int i=0; i < arrayRandom.Length; i++)
{
if(arrayRandom[i] >= 0)
    sumPositive += arrayRandom[i];
else
    sumNegative += arrayRandom[i];  
}

Console.WriteLine();
Console.WriteLine($" Сумма положительных чисел равна {sumPositive}");
Console.WriteLine($" Сумма отрицательных чисел равна {sumNegative}");

