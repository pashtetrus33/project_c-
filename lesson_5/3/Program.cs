Console.Clear();
int[] arrayFill(int sizeOfArray, int x, int y)
{
int[] randomArray = new int[sizeOfArray];
for(int i=0; i < randomArray.Length; i++)
{
randomArray[i] = new Random().Next(x, y+1);
Console.Write($"{randomArray[i]} ");
}
Console.WriteLine();
return randomArray;
}

int[] randomArray = arrayFill(sizeOfArray:9, x:0, y:200);

void countElements (int[] array)
{
int count = 0;
for(int i=0; i < array.Length; i++)
if ((array[i] >= 10) && (array[i] <= 99))
count++;
Console.WriteLine($"Количество элементов массива в диапазоен [10,99] {count}");
}

void printMultPairs(int[] array)
{
for(int i=0; i < array.Length/2; i++)
Console.Write($" {array[i]*array[array.Length -i-1]} ");
if (array.Length % 2  !=0)
Console.Write($" {array[array.Length/2]} ");
Console.WriteLine();
}

Console.WriteLine("Задача 35:");
countElements(randomArray);

Console.WriteLine("Задача 37:");
printMultPairs(randomArray);
