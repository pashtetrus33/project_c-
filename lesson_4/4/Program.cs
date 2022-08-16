Console.Clear();

int arrayLength = 8;
int[] createArray()
{
int [] randomArray = new int[arrayLength];
for (int i = 0; i < arrayLength; i++)
randomArray[i] = new Random().Next(0,2);
return randomArray;
}

void printArray(int[] array)
{
for (int i = 0; i < arrayLength; i++)
 Console.Write($"{array[i]} ");
 Console.WriteLine();
}

printArray(createArray());













