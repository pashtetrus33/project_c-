Console.Clear();
int[] arr = {1,4,5,6,7,8,9,1,1,3,4,5,7};

void printArray (int[] array)
{
for (int i = 0; i < array.Length; i++)
Console.Write($"{array[i]} ");
Console.WriteLine();
Console.WriteLine(array.Length);
}

void sortArray (int[] array)
{
for (int i = 0; i < array.Length-1; i++)
    {
    int maxPosition = i;
        for (int j = i+1; j < array.Length; j++)
            {
                if (array[j] > array[maxPosition])
                maxPosition = j;
            }   
        int temprory = array[i];
            array[i] = array[maxPosition];
            array[maxPosition] = temprory;
    }  
}

printArray(arr);
sortArray(arr);
printArray(arr);

